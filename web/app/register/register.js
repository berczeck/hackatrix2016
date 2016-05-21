'use strict';

angular.module('myApp.register', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/register', {
    templateUrl: 'register/register.html',
    controller: 'RegisterCrtl'
  });
}])

.controller('RegisterCrtl', ['$scope', '$timeout', '$http', function($scope, $timeout, $http) {
  $scope.imageUrl = '';
  $scope.wantedBooks =[];
  $scope.booksFoundByIsbn = [];
    
    
  $scope.addWantedBook = function () {
    $scope.wantedBooks.push('');
  };

  $scope.findBookByIsbn = function (){
      $scope.booksFoundByIsbn = [
          { name: 'Libro 1' }
      ];
  };

    $scope.selectBookFound =  function (index) {
        var bookInfo = $scope.booksFoundByIsbn[index];
        $scope.title = bookInfo.name;
        $scope.booksFoundByIsbn =[];
        $timeout(function () {
            Materialize.updateTextFields();
        }, 200)

    };

    $scope.saveData = function () {
        var data =  {
            'imageUrl': $scope.imageUrl,
            'isbn': $scope.isbn,
            'title': $scope.title,
            'author': $scope.locations,
            'tags': $scope.tags.split(','),
            'description': $scope.description,
            //'comments': [{}]
        };

        savePost(data);
    };


    function savePost(data) {
        $http.post('http://172.28.11.140/Hackatrix2016/api/books', data).then(successSave, errorSave);

        function successSave(result) {
            console.log(result)
        }

        function errorSave(errorStatus) {
            console.log(errorStatus)
            console.log("Error");
        }
    }
    
    function getBookByIsbn(){
        
    }
    
}]);