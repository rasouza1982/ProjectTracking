(function () {
    var projectTasksService = function ($http) {
        var projectTasks = function () {
            return $http.get("http://localhost:55559/api/projecttasks")
                        .then(function (response) {
                            return response.data;
                        });
        };
        return {
            projectTasks: projectTasks
        };
    };
    var module = angular.module("ProjectTrackingModule");
    module.factory("projectTasksService", ["$http", projectTasksService]);
}());