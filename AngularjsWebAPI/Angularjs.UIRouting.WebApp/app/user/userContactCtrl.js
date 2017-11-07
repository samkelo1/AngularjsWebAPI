
var app = angular.module("MyApp");
app.controller("UserContactCtrl", ['$scope', '$state', '$stateParams', '$modal', '$log', 'User', function ($scope, $state, $stateParams, $modal, $log, User) {

    var UserId = $stateParams.UserId;

    $scope.UserContacts = function (id) {
        return User.UserContacts(id)
        .then(function (data) {
            $scope.contacts = User.conntacts;
        });
    };

    $scope.UserContacts(UserId);
}]);