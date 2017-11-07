angular.module('MyApp')
       .factory('User', ['$q', '$http', function ($q, $http) {

           var baseUrl = 'api/User/';
           var contactBaseUrl = 'api/Contact/';

           var UserService = {};
           UserService.Users = [];
           UserService.currentUser = {};

           // Search Users
           UserService.search = function (text) {
               var deferred = $q.defer();
               return $http({
                   url: baseUrl + 'search',
                   method: 'GET',
                   params: { 'searchText': text },
                   cache: true
               }).success(function (data) {
                   deferred.resolve(
                       UserService.Users = data);
               }).error(function (error) {
                   deferred.reject(error);
               })
               return deferred.promise;
           }

           // New Users
           UserService.newUser = function () {
               var deferred = $q.defer();
               return $http.get(baseUrl + "new")
                    .success(function (data) {
                        deferred.resolve(UserService.User = data);
                    })
               .error(function (error) {
                   deferred.reject(error);
               })
               return deferred.promise;
           }

           // Save User
           UserService.Save = function (User, files) {
               var deferred = $q.defer();
               return $http.post(baseUrl + "Save", User)
                .success(function (data) {
                    deferred.resolve(UserService.User = data);
                })

               .error(function (error) {
                   deferred.reject(error);
               });
               return deferred.promise;
           }

           // Users detail by User id
           UserService.UserDetail = function (id) {
               var deferred = $q.defer();
               return $http.get(baseUrl + "detail/" + id)
                    .success(function (data) {
                        deferred.resolve(
                            UserService.currentUser = data);
                    })
               .error(function (error) {
                   deferred.reject(error);
               })
               return deferred.promise;
           }

           // delete Users
           UserService.delete = function (id) {
               var deferred = $q.defer();
               return $http.post(baseUrl + "delete/" + id)
                    .success(function (data) {
                        deferred.resolve();
                    })
               .error(function (error) {
                   deferred.reject(error);
               })
               return deferred.promise;
           }
                      
           /*       User CONTACTS
            ************************************/
           UserService.UserContacts = function (id) {
               var deferred = $q.defer();
               return $http.get(contactBaseUrl + "ByUserId/" + id)
                    .success(function (data) {
                        deferred.resolve(UserService.conntacts = data);
                    }).error(function (error) {
                        deferred.reject(error);
                    })
               return deferred.promise;
           }

           return UserService;
       }]);