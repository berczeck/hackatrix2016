'use strict';

angular.module('myApp.register', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/register', {
    templateUrl: 'register/register.html',
    controller: 'RegisterCrtl'
  });
}])

.controller('RegisterCrtl', ['$scope', function($scope) {
  $scope.imageUrl = '';
  $scope.wantedBooks =[];
  $scope.addWantedBook = function () {
    $scope.wantedBooks.push('');
  };

  

}]);