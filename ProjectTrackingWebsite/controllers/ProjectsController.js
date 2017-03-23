(function () {
    'use sctrict';
    var ProjectsController = function ($scope, projectService, $log, $routeParams) {
        var projects = function (data) {
            $scope.Projects = data;
        };

        var singleProject = function(data) {
            $scope.existingProject = data;
            $log.info(data);
        };

        $scope.init = function () {
            projectService.singleProject($routeParams.projectID).then(singleProject, errorDetails);
        };

        var project = {
            projectID: null,
            projectName: null,
            startDate: null,
            endDate: null,
            clientName:null
        };

        $scope.project = project;
        projectService.projects().then(projects, errorDetails);

        var errorDetails = function (response) {
            $scope.Error = "Something went wrong ??";
        };

        $scope.insertProject= function(project) {
            projectService.insertProject(project)
                .then(projectService.projects().then(projects, errorDetails));
        }

        $scope.ModifyProject = function (existingProject) {
            $log.info(existingProject);
            projectService.modifyProject(existingProject)
                .then(projectService.projects().then(projects, errorDetails));
        };

        $scope.DeleteProject = function (project) {
            $log.info(project);
            projectService.deleteProject(project)
                .then(projectService.projects().then(projects, errorDetails));
        };

        
        $scope.Title = "Project Details Page";
    };
    //app.controller("ProjectsController", ["$scope", "projectService", "$log", ProjectsController]);
    app.controller("ProjectsController", ProjectsController);
}());