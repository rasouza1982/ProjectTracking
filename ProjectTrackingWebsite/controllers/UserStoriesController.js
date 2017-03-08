(function () {
    var UserStoriesController = function ($scope, $http) {
        var userStories = function (response) {
            $scope.Stories = response.data;
        };
        var errorDetails = function (response) {
            $scope.Error = "Something went wrong ??";
        };
        $http.get("http://localhost:55559/api/userstories/1")
            .then(userStories, errorDetails);

        $scope.Title = "User Stories Page";
    };
    app.controller("UserStoriesController", UserStoriesController);
}());