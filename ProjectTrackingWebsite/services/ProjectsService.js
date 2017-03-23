(function () {
    'use sctrict';
    var projectService = function ($http, $log) {
        var projects = function () {
            return $http.get("http://localhost:55559/api/projects")
                    .then(function (response) {
                        return response.data;
                    });
        };

        var insertProject = function (project) {
            return $http.post("http://localhost:55559/api/projects", project)
                    .then(function() {
                        $log.info("Insert Project Successfull!");
                        return;
                    });
        };

        var singleProject = function (id) {
            return $http.get("http://localhost:55559/api/projects/" + id)
                    .then(function (response) {
                        return response.data;
                    });
        };
        var modifyProject = function (project) {
            return $http.put("http://localhost:55559/api/projects/" + project.projectID, project)
                    .then(function (response) {
                        $log.info("Update Successful");
                        return;
                    });
        };

        return {
            projects: projects,
            insertProject: insertProject,
            modifyProject: modifyProject
        };
    };
    var module = angular.module("ProjectTrackingModule");
    module.factory("projectService", projectService);
    //module.factory("projectService", ["$http", projectService]);
}());