'use strict';

angular.module('myApp.lookfor', ['ngRoute'])

.config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/lookfor', {
    templateUrl: 'lookfor/lookfor.html',
    controller: 'LookforCrtl'
  });
}])

.controller('LookforCrtl', [function() {

}]);