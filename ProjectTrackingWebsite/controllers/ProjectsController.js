(function () {
    var ProjectsController = function ($scope, $http) {
        var projects = function (response) {
            $scope.Projects = response.data;
        };
        var errorDetails = function (response) {
            $scope.Error = "Something went wrong ??";
        };
        $http.get("http://localhost:55559/api/projects")
            .then(projects, errorDetails);
        $scope.Title = "Project Details Page";
    };
    app.controller("ProjectsController", ProjectsController);
}());