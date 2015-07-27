zooModule.controller("insectsController", ["$scope", "bootstrappedData", function ($scope, bootstrappedData) {
    $scope.insects = bootstrappedData.insects;
}]);