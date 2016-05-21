'use strict';

angular.module('myApp.register', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/register', {
    templateUrl: 'register/register.html',
    controller: 'RegisterCrtl'
  });
}])

.controller('RegisterCrtl', ['$scope', '$timeout', function($scope, $timeout) {
  $scope.imageUrl = '';
  $scope.wantedBooks =[];
  $scope.booksFoundByIsbn = [];
    
    
  $scope.addWantedBook = function () {
    $scope.wantedBooks.push('');
  };

  $scope.findBookByIsbn = function (){
      $scope.booksFoundByIsbn = [
          { name: 'Libro 1' },
          { name: 'Libro 2' }
      ];
    }

    $scope.selectBookFound =  function (index) {
        var bookInfo = $scope.booksFoundByIsbn[index];
        $scope.title = bookInfo.name;
        $scope.booksFoundByIsbn =[];
        $timeout(function () {
            Materialize.updateTextFields();
        }, 200)

    }

}]);