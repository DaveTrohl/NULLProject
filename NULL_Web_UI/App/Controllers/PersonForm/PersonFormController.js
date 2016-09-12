"use strict";

angular.module("nullWeb")
    .controller("PersonFormController", PersonFormController);

function PersonFormController($scope)
{
    $scope.message = "Hello World";
}