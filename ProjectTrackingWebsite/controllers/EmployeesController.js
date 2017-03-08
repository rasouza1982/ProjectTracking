(function () {
    var EmployeesController = function ($scope, $http) {
        var employees = function (serviceResp) {
            $scope.Employees = serviceResp.data;

        };
        $scope.SearchEmployees = function (EmployeeName) {
            console.log("Entrou Search:", EmployeeName);
            $http.get("http://localhost:55559/api/employees/" + EmployeeName)
            .then(employees, errorDetails);
        };
        var errorDetails = function (serviceResp) {
            $scope.Error = "Something went wrong ??";
        };
        $http.get("http://localhost:55559/api/employees")
            .then(employees, errorDetails);
        $scope.Title = "Employee Details Page";
        $scope.EmployeeName = null;
    };
    app.controller("EmployeesController", EmployeesController);
}());



//(function () {
//    var EmployeesController = function ($scope, $http) {
//        var employees = function (response) {
//            $scope.Employees = response.data;
//        };

//        $scope.SearchEmployees = function (EmployeeName) {
//            $http.get("http://localhost:55559/api/employees/" + EmployeeName)
//            .then(employees, errorDetails);
//        };

//        var errorDetails = function (response) {
//            $scope.Error = "Something went wrong ??";
//        };

//        $http.get("http://localhost:55559/api/employees")
//            .then(employees, errorDetails);

//        $scope.Title = "Employee Details Page";
//        $scope.EmployeeName = null;
//    };
//    app.controller("EmployeesController", EmployeesController);
//}());