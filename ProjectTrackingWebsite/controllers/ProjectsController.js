(function () {
    var ProjectsController = function ($scope, projectService) {
        var projects = function (data) {
            $scope.Projects = data;
        };
        var errorDetails = function (response) {
            $scope.Error = "Something went wrong ??";
        };
        projectService.projects().then(projects, errorDetails);
        $scope.Title = "Project Details Page";
    };
    app.controller("ProjectsController", ["$scope", "projectService", ProjectsController]);
}());