var mainApp = angular.module("nullApp", ['ngRoute']);

mainApp.config(function ($routeProvider) {
    $routeProvider
		.when('/', {
		    templateUrl: '../App/Home/Home.html'
		})
		.when('/personForm', {
		    templateUrl: '../App/PersonForm/PersonForm.html',
		    controller:  'PersonController'
		})
		.otherwise({
		    redirectTo: '/'
		});
});