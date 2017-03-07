(function () {
    var EmployeesController = function ($scope, $http) {
        var employees = function (response) {
            $scope.Employees = response.data;
        };
        var errorDetails = function (response) {
            $scope.Error = "Something went wrong ??";
        };

        $http.get("http://localhost:55559/api/employees").then(employees, errorDetails);

        $scope.Title = "Employee Details Page";
    };
    app.controller("EmployeesController", EmployeesController);
}());