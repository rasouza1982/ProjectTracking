(function () {
    'use sctrict';
    var ManagerCommentsController = function ($scope, managerCommentsService) {
        var managerComments = function (data) {
            $scope.Comments = data;
        };
        var errorDetails = function (response) {
            $scope.Error = "Something went wrong ??";
        };
        managerCommentsService.managerComments().then(managerComments, errorDetails);
        $scope.Title = "Manager comments Page";
    };
    app.controller("ManagerCommentsController", ["$scope", "managerCommentsService", ManagerCommentsController]);

}());


//(function () {
//    var ManagerCommentsController = function ($scope, $http) {
//        var managerComments = function (serviceResp) {
//            $scope.Comments = serviceResp.data;
//        };
//        var errorDetails = function (serviceResp) {
//            $scope.Error = "Something went wrong ??";
//        };
//        $http.get("http://localhost:55559/api/managercomments/1")
//            .then(managerComments, errorDetails);
//        $scope.Title = "Manager comments Page";
//    };
//    app.controller("ManagerCommentsController", ManagerCommentsController);
//}());