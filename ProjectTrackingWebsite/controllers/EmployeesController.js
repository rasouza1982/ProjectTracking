(function () {
    var EmployeesController = function ($scope, employeeService, $log) {
        var employees = function (data) {
            $scope.Employees = data;

        };
        $scope.searchEmployees = function (employeeName) {
            employeeService.searchEmployees(employeeName)
            .then(employees, errorDetails);

            $log.info("Found Employee which contains - " + employeeName);
        };
        var errorDetails = function (response) {
            $scope.Error = "Something went wrong ??";
        };

        employeeService.employees()
            .then(employees, errorDetails);

        $scope.Title = "Employee Details Page";
        $scope.EmployeeName = null;

    };
    app.controller("EmployeesController", ["$scope", "employeeService", "$log", EmployeesController]);
}());






//(function () {
//    var EmployeesController = function ($scope, $http, $log) {
//        var employees = function (serviceResp) {
//            $scope.Employees = serviceResp.data;

//        };
//        $scope.SearchEmployees = function (EmployeeName) {
//            $http.get("http://localhost:55559/api/employees/" + EmployeeName)
//            .then(employees, errorDetails);
//            $log.info("Found Employee which contains - " + EmployeeName);
//        };
//        var errorDetails = function (serviceResp) {
//            $scope.Error = "Something went wrong ??";
//        };
//        $http.get("http://localhost:55559/api/employees")
//            .then(employees, errorDetails);
//        $scope.Title = "Employee Details Page";
//        $scope.EmployeeName = null;
//    };
//    app.controller("EmployeesController", EmployeesController);
//}());

