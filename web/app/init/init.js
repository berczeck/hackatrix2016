'use strict';

angular.module('myApp.init', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/init', {
    templateUrl: 'init/init.html',
    controller: 'InitCtrl'
  });
}])

.controller('InitCtrl', [function() {

}]);