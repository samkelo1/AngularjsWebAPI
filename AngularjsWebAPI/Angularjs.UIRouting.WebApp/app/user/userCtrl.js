var app = angular.module("MyApp")
app.controller('UserCtrl', ['$scope', '$state', '$stateParams', '$modal', '$log', 'User', function ($scope, $state, $stateParams, $modal, $log, User) {

    var UserId = $stateParams.UserId;

    $scope.searchText = '';
    $scope.Users = searchUsers();
    $scope.contacts = [];
    $scope.User = null;
    $scope.currentUser = null;


    $scope.$watch('searchText', function (newVal, oldVal) {
        if (newVal != oldVal) {
            searchUsers();
        }
    }, true);


    function searchUsers() {
        User.search($scope.searchText)
        .then(function (data) {
            $scope.Users = User.Users;
        });
    };

    $scope.UserDetail = function (id) {
        if (!id) return;
        User.UserDetail(id)
        .then(function (data) {
            $scope.currentUser = User.currentUser;
            $state.go('User.detail', { 'UserId': id });
        });
    };

    /* Need to call after defining the function
       It will be called on page refresh        */
    $scope.currentUser = $scope.UserDetail(UserId);

    // Delete a User and hide the row
    $scope.deleteUser = function ($event, id) {
        var ans = confirm('Are you sure to delete it?');
        if (ans) {
            User.delete(id)
            .then(function () {
                var element = $event.currentTarget;
                $(element).closest('div[class^="col-lg-12"]').hide();
            })
        }
    };

    // Add User
    $scope.addUser = function () {
        User.newUser()
        .then(function (data) {
            $scope.User = User.User;
            $scope.open('sm');
        });
    }

    // Edit User
    $scope.editUser = function () {
        $scope.User = $scope.currentUser;
        $scope.open('lg');
    }

    // Open model to add edit User
    $scope.open = function (size) {        
        var modalInstance = $modal.open({
            animation: false,
            backdrop: 'static',
            templateUrl: 'app/User/AddEditUser.html',
            controller: 'UserModalCtrl',
            size: size,
            resolve: {
                User: function () {
                    return $scope.User;
                }
            }
        });
        modalInstance.result.then(function (response) {
            $scope.currentUser = response;
            $state.go('User.detail', { 'UserId': response.UserId });            
        }, function () {
            $log.info('Modal dismissed at: ' + new Date());
        });
    };


    
}]);

app.controller('UserModalCtrl', ['$scope', '$modalInstance', 'User', 'User', function ($scope, $modalInstance, User, User) {

    $scope.User = User;
    
    if (User.UserId > 0)
        $scope.headerTitle = 'Edit User';
    else
        $scope.headerTitle = 'Add User';
    
    $scope.save = function () {
        User.Save($scope.User).then(function (response) {
            $modalInstance.close(response.data);
        })
    };

    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };

}]);
