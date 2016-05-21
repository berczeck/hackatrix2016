'use strict';

angular.module('myApp.match', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/match', {
    templateUrl: 'match/match.html',
    controller: 'MatchCtrl'
  });
}])

.controller('MatchCtrl', ['$scope', function ($scope) {

  $scope.book = {
      // img: 'http://akamaicovers.oreilly.com/images/0636920035848/cat.gif',
      img: 'assets/book.gif',
      name: 'Libro 1',
      holder: 'juan',
      isbn: '234343FG',
      desc: 'Cool book',
      tags: 'Cool, stuff, code'
  };

  $scope.backgroundImgStyle = function (book) {
    return {"background-image": "url(" + book.img + ")"};
  }

  $scope.lookingToShare = false;

  $scope.goLooking = function () {
    $scope.lookingToShare = !$scope.lookingToShare;
  }

  $scope.myBooks = [
    {
      name: 'My book 1'
    },
    {
      name: 'My book 2'
    },
    {
      name: 'My book 3'
    },
    {
      name: 'My book 4'
    },
    {
      name: 'My book 5'
    },
    {
      name: 'My book 6'
    }
  ]

}]);