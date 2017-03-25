(function () {
    'use sctrict';
    var projectService = function ($http, $log) {
        var urlApi = "http://localhost:55559/api/projects";
        var projects = function () {
            return $http.get(urlApi)
                    .then(function (response) {
                        return response.data;
                    });
        };

        var insertProject = function (project) {
            return $http.post(urlApi, project)
                    .then(function() {
                        $log.info("Insert Project Successfull!");
                        return;
                    });
        };

        var singleProject = function (id) {
            return $http.get(urlApi + "/" + id)
                    .then(function (response) {
                        return response.data;
                    });
        };

        var modifyProject = function (project) {
            $log.info("entrou em modify service", project);
            return $http.put(urlApi + "/" + project.projectId, project)
                    .then(function (response) {
                        $log.info("Update Successful");
                        return;
                    });
        };

        var deleteProject = function (project) {
            $log.info("entrou em delete service", project);
            return $http.delete(urlApi + "/" + project.projectId, project)
                    .then(function (response) {
                        $log.info("Delete Successful");
                        return;
                    });
        };

        return {
            projects: projects,
            insertProject: insertProject,
            modifyProject: modifyProject,
            singleProject: singleProject,
            deleteProject: deleteProject
        };
    };
    var module = angular.module("ProjectTrackingModule");
    module.factory("projectService", projectService);
    //module.factory("projectService", ["$http", projectService]);
}());