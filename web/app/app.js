'use strict';

// Declare app level module which depends on views, and components
angular.module('myApp', [
  'ngRoute',
  'myApp.init',
  'myApp.lookfor',
  'myApp.register',
  'myApp.match'
]).
config(['$routeProvider', function($routeProvider) {
  $routeProvider.otherwise({redirectTo: '/init'});
}]);

// angular.module('myApp')

// .directive('myCustomer', function() {
//   return {
//     templateUrl: 'app/.html'
//   };
// });