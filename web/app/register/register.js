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
    $scope.hastIsbnResults = false;
    
    
  $scope.addWantedBook = function () {
    $scope.wantedBooks.push('');
  };

  // $scope.findBookByIsbn = function (){
  //     $scope.booksFoundByIsbn = [
  //         { name: 'Libro 1' }
  //     ];
  // };

    $scope.selectBookFound =  function (index) {
        var bookInfo = $scope.booksFoundByIsbn[index];
        $scope.title = bookInfo.title;
        $scope.imageUrl = bookInfo.imageUrl;
        $scope.booksFoundByIsbn =[];
        $timeout(function () {
            Materialize.updateTextFields();
        }, 200)

    };

    $scope.saveData = function () {
        var data =  {
            'imageUrl': $scope.imageUrl || '',
            'isbn': $scope.isbn || '',
            'title': $scope.title || '',
            'author': $scope.locations || '',
            'tags': $scope.tags ? $scope.tags.split(',') : [],
            'description': $scope.description || '',
            //'comments': [{}]
        };

        savePost(data);
    };


    function savePost(data) {
        $http.post('http://172.28.11.140/Hackatrix2016/api/books', data).then(successSave, errorSave);

        function successSave(result) {
            console.log(result);
            $('#modalConfirmRegister').openModal();
        }

        function errorSave(errorStatus) {
            console.log(errorStatus);
            console.log("Error");
        }
    }
    
    $scope.findBookByIsbn = function (){
        //9781451648546
        $http.get('http://172.28.11.140/Hackatrix2016/api/books/find?isbn=' + $scope.isbn).then(successSave1, errorSave1);

        function successSave1(result) {
            console.log(result);
            if(result.data){
                $scope.hastIsbnResults = true;
                $scope.booksFoundByIsbn = [result.data];
            }
        }

        function errorSave1(errorStatus) {
            console.log(errorStatus);
            console.log("Error");
        }
    }
    
}]);