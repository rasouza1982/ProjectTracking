(function () {
    var employeeService = function ($http) {
        var employees = function () {
            return $http.get("http://localhost:55559/api/employees")
                    .then(function (response) {
                        return response.data;
                    });
        };
        var searchEmployees = function (employeeName) {
            return $http.get("http://localhost:55559/api/employees/" + employeeName)
                    .then(function (response) {
                        return response.data;
                    });
        };

        return {
            employees: employees,
            searchEmployees: searchEmployees
        };
    };
    var module = angular.module("ProjectTrackingModule");
    module.factory("employeeService", ["$http", employeeService]);
}());