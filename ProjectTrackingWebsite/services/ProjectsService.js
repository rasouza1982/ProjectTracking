(function () {
    var projectService = function ($http) {
        var projects = function () {
            return $http.get("http://localhost:55559/api/projects")
                    .then(function (response) {
                        return response.data;
                    });
        };
        return {
            projects: projects
        };
    };
    var module = angular.module("ProjectTrackingModule");
    module.factory("projectService", ["$http", projectService]);
}());