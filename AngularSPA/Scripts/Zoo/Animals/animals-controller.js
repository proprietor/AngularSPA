zooModule.controller("animalsController", ["$scope", "bootstrappedData", function ($scope, bootstrappedData) {
    $scope.animals = bootstrappedData.animals;
}]);
