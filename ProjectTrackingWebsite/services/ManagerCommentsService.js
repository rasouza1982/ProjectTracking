(function () {
    var managerCommentsService = function ($http) {
        var managerComments = function () {
            return $http.get("http://localhost:55559/api/managercomments")
                        .then(function (response) {
                            return response.data;
                        });
        };
        return {
            managerComments: managerComments
        };
    };
    var module = angular.module("ProjectTrackingModule");
    module.factory("managerCommentsService", ["$http", managerCommentsService]
);
}());