var zooModule = angular.module("zooModule", ["ngRoute"])
    .config(function($routeProvider, $locationProvider) {
    $routeProvider
        .when("/Animals", { templateUrl: "Scripts/Zoo/templates/animals.html", controller: "animalsController" })
        .when("/Insects", { templateUrl: "Scripts/Zoo/templates/insects.html", controller: "insectsController" })
        .when("/Reptiles", { templateUrl: "Scripts/Zoo/templates/reptiles.html", controller: "reptilesController" });
    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
});

