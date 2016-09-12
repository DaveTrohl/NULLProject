//"use strict";

//var app = angular.module("nullWeb",
//    [
//        // Angular Modules
//        "ngRoute"

//        // Third Party Modules
//    ]);

//app.config(function ($routeProvider) {
//    $routeProvider
//        .when("/", {
//            templateUrl: "Controllers/Home/Home.html",
//            //controller:  "HomeController"
//        }
//        .when("/Person", {
//            templateUrl: "Controllers/PersonForm/PersonForm.Html",
//            //controller:  "PersonFormController"
//        })
//        .otherwise({
//            redirectTo: "/"
//        }));
//});

//app.run(["$route", function ($route) {
    
//}]);

(function() {
    "use strict";

    var app = angular.module("nullWeb",
    [
        // Angular Modules
        "ngRoute"

        // Third Party Modules
    ]);

    app.config(['$routeProvider', configRoutes]);

    function configRoutes($routeProvider) {
        $routeProvider
            .when("/",
            {
                templateUrl: "Controllers/Home/Home.html",
                controller: "HomeController"
            }
            .when("/Person",
            {
                templateUrl: "Controllers/PersonForm/PersonForm.Html",
                controller: "PersonFormController"
            })
            .otherwise(
            {
                redirectTo: "/"
            }));
    }

    app.run(["$route", function ($route) {

    }]);
})();