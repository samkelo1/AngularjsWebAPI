
angular.module("MyApp")
       .controller("contactCtrl", ['$scope', function ($scope) {

           var headOffice = {
               'address': '343 Cornubia,Durban 4300',
               'contactNo': '(065) 628-3327',
               'HomePhone': '(072) 628-3328',
               'WorkEmail': 'headoffice@assessment.com',
           };

           var branch1 = {
               'address': 'New Branch',
               'contactNo': '(065) 628-1127',
               'HomePhone': '(072) 628-1128',
               'WorkEmail': 'nwe@assessment.com',
           };


           var branch2 = {
               'address': '343 Cornubia,Durban 4300',
               'contactNo': '(065) 628-1027',
               'HomePhone': '(072) 628-1028',
               'WorkEmail': 'brach2office@assessment.com',
           };

           $scope.pageTitle = 'Contact Us';
           $scope.headOffice = headOffice;
           $scope.branch1 = branch1;
           $scope.branch2 = branch2;

       }]);