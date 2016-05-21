'use strict';

angular.module('myApp.lookfor', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/lookfor', {
    templateUrl: 'lookfor/lookfor.html',
    controller: 'LookforCrtl'
  });
}])

.controller('LookforCrtl', ['$scope','$location', '$http', function($scope, $location, $http) {

  $scope.books = [];

  $http.get('http://172.28.11.140/Hackatrix2016/api/books/all')

  .then(function (response) {

    for (var i = response.data.length - 1; i >= 0; i--) {
      $scope.books.push({
        img: response.data[i].imageUrl ? response.data[i].imageUrl : 'http://akamaicovers.oreilly.com/images/0636920035848/cat.gif',
        name: response.data[i].title,
        holder: 'juan',
        isbn: response.data[i].isbn
      });
      // debugger;
    }
  });


  // $scope.books = [
  //   {
  //     // img: 'http://akamaicovers.oreilly.com/images/0636920035848/cat.gif',
  //     img: 'assets/book.gif',
  //     name: 'Libro 1',
  //     holder: 'juan',
  //     isbn: '234343FG'
  //   },
  //   {
  //     // img: 'http://akamaicovers.oreilly.com/images/0636920035848/cat.gif',
  //     img: 'assets/book.gif',
  //     name: 'Libro 2',
  //     holder: 'pedro',
  //     isbn: 'dfdsfsd23213'
  //   },
  //   {
  //     // img: 'http://akamaicovers.oreilly.com/images/0636920035848/cat.gif',
  //     img: 'assets/book.gif',
  //     name: 'Libro 3',
  //     holder: 'jhon',
  //     isbn: 'dfdsfsd23213'
  //   },
  //   {
  //     // img: 'http://akamaicovers.oreilly.com/images/0636920035848/cat.gif',
  //     img: 'assets/book.gif',
  //     name: 'Libro 4',
  //     holder: 'lucho',
  //     isbn: 'dfdsfsd23213'
  //   }
  // ];

  $scope.lookForBook = '';

  $scope.backgroundImgStyle = function (book) {
    return {"background-image": "url(" + book.img + ")"};
  }

  $scope.goMatch = function (book) {
    $location.url('/match')
  }

}]);