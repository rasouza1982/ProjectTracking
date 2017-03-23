(function () {
    'use sctrict';
    var UserStoriesController = function ($scope, userStoriesService) {
        var userStories = function (data) {
            $scope.Stories = data;
        };
        var errorDetails = function (response) {
            $scope.Error = "Something went wrong ??";
        };
        userStoriesService.userStories().then(userStories, errorDetails);
        $scope.Title = "User Stories Page";
    };
    app.controller("UserStoriesController", ["$scope", "userStoriesService", UserStoriesController]);

}());