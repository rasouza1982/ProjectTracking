(function () {
    var ProjectsController = function ($scope, projectService, $log) {
        var projects = function (data) {
            $scope.Projects = data;
        };
        var project = {
            projectID: null,
            projectName: null,
            startDate: null,
            endDate: null,
            clientName:null
        };

        $scope.project = project;

        var errorDetails = function (response) {
            $scope.Error = "Something went wrong ??";
        };

        $scope.insertProject= function(project) {
            projectService.insertProject(project)
                .then(projectService.projects().then(projects, errorDetails));
        }

        projectService.projects().then(projects, errorDetails);
        $scope.Title = "Project Details Page";
    };
    app.controller("ProjectsController", ["$scope", "projectService", "$log", ProjectsController]);
}());