'use strict';

angular.module('myApp.register', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/register', {
    templateUrl: 'register/register.html',
    controller: 'RegisterCrtl'
  });
}])

.controller('RegisterCrtl', ['$scope', function($scope) {
  // $scope.imageUrl = imgUrl;
  // $scope.title = title;
  // $scope.isbn = isbn;
  // $scope.description =  description;
  // $scope.tags = Array.isArray(tags) ? tags : [];
  // $scope.wantedBooks = Array.isArray(books) ? books : [];
  
  /*function Post(imgUrl, title, isbn, description, tags, books) {
    this.imageUrl = imgUrl;
    this.title = title;
    this.isbn = isbn;
    this.description =  description;
    this.tags = Array.isArray(tags) ? tags : [];
    this.wantedBooks = Array.isArray(books) ? books : [];
  }*/

}]);