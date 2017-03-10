(function () {
    var projectService = function ($http, $log) {
        var projects = function () {
            return $http.get("http://localhost:55559/api/projects")
                    .then(function (response) {
                        return response.data;
                    });
        };
        var insertProject = function(project) {
            return $http.post("http://localhost:55559/api/projects", project)
                .then(function() {
                    $log.info("Insert Project Successfull!");
                    return;
                });
        };
        return {
            projects: projects,
            insertProject: insertProject
        };
    };
    var module = angular.module("ProjectTrackingModule");
    module.factory("projectService", projectService);
    //module.factory("projectService", ["$http", projectService]);
}());