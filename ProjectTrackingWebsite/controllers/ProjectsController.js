﻿(function () {
    'use sctrict';
    var ProjectsController = function ($scope, projectService, $log, $routeParams) {
        var projects = function (data) {
            $scope.Projects = data;
        };

        var singleProject = function(data) {
            $scope.project = data;
            $log.info(data);
        };

        $scope.init = function () {
            console.log("$routeParams.projectID:", $routeParams.projectID);
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

        $scope.modifyProject = function (project) {
            $log.info("entrou em modify controller");
            $log.info(project);
            projectService.modifyProject(project)
                .then(projectService.projects().then(projects, errorDetails));
        };

        $scope.deleteProject = function (project) {
            $log.info(project);
            projectService.deleteProject(project)
                .then(projects, errorDetails);
        };

        //var refresh = function () {
        //    projectService.projects()
        //        .then(projects, errorDetails);
        //};

        //refresh();
        $scope.Title = "Project Details Page";
    };
    //app.controller("ProjectsController", ["$scope", "projectService", "$log", ProjectsController]);
    app.controller("ProjectsController", ProjectsController);
}());