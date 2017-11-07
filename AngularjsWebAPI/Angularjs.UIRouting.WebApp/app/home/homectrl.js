

angular.module("MyApp")
       .controller("homeCtrl", ['$scope', function ($scope) {
           $scope.pageTitle = 'Home';
           $scope.message6 = 'Note: This is a Code first Applicition, all what you need is create database and connect to it(using DefaultConnection) without creating tables(but userDB backup is provided),all tables will be generated from classes after adding your connection build and run your appliction.';
           $scope.message = 'To add,delete or update Users click User/Contact in navigational menu, I also added some functoinality on About us to share some knowledge';
           $scope.message3 = 'Time required to finish this requirement in minutes : 4 hours 19:minutes';
           $scope.message4 = 'Date time when you started :07/11/2017 :19:00';
           $scope.message5 = 'Start Date time when you finished :07/11/2017 23:19 ';
           $scope.message1 = 'Created by Samkelo Ngubo';
       }]);
