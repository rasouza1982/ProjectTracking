(function () {
    var ProjectTasksController = function ($scope, $http) {
        var projectTasks = function (serviceResp) {
            $scope.Tasks = serviceResp.data;
        };
        var errorDetails = function (serviceResp) {
            $scope.Error = "Something went wrong ??";
        };
        $http.get("http://localhost:55559/api/projecttasks/1")
            .then(projectTasks, errorDetails);
        $scope.Title = "Project Tasks Page";
    };
    app.controller("ProjectTasksController", ProjectTasksController);
}());