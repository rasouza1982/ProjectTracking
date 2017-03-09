(function () {
    var userStoriesService = function ($http) {
        var userStories = function () {
            return $http.get("http://localhost:55559/api/userstories")
                        .then(function (response) {
                            return response.data;
                        });
        };
        return {
            userStories: userStories
        };
    };
    var module = angular.module("ProjectTrackingModule");
    module.factory("userStoriesService", ["$http", userStoriesService]);
}());