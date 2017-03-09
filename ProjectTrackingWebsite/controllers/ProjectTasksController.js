(function () {
    var ProjectTasksController = function ($scope, projectTasksService) {
        var projectTasks = function (data) {
            $scope.Tasks = data;
        };
        var errorDetails = function (response) {
            $scope.Error = "Something went wrong ??";
        };
        projectTasksService.projectTasks().then(projectTasks, errorDetails);
        $scope.Title = "Project Tasks Page";
    };

    app.controller("ProjectTasksController", ["$scope", "projectTasksService", ProjectTasksController]);

}());



//(function () {
//    var ProjectTasksController = function ($scope, $http) {
//        var projectTasks = function (serviceResp) {
//            $scope.Tasks = serviceResp.data;
//        };
//        var errorDetails = function (serviceResp) {
//            $scope.Error = "Something went wrong ??";
//        };
//        $http.get("http://localhost:55559/api/projecttasks/1")
//            .then(projectTasks, errorDetails);
//        $scope.Title = "Project Tasks Page";
//    };
//    app.controller("ProjectTasksController", ProjectTasksController);
//}());

