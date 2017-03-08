(function () {
    var ManagerCommentsController = function ($scope, $http) {
        var managerComments = function (serviceResp) {
            $scope.Comments = serviceResp.data;
        };
        var errorDetails = function (serviceResp) {
            $scope.Error = "Something went wrong ??";
        };
        $http.get("http://localhost:55559/api/managercomments/1")
            .then(managerComments, errorDetails);
        $scope.Title = "Manager comments Page";
    };
    app.controller("ManagerCommentsController", ManagerCommentsController);
}());