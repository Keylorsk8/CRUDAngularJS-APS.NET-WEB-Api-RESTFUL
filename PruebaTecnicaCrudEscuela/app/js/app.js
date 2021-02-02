var app = angular.module("EscuelaApp", ["ngRoute","ngResource","ngAnimate"])
    .config(['$locationProvider', function ($locationProvider) {
        $locationProvider.hashPrefix('');
    }]);

    app.config(function ($routeProvider) {
        $routeProvider
            .when("/", {
                redirectTo: function () {
                    return "/home";
                }
            })
            .when("/home", {
                controller: "homecontroller",
                templateUrl: "../../app/views/home.html"
            })
            .when("/estudiantes", {
                controller: "estudiantecontroller",
                templateUrl: "../../app/views/ListEstudiantes.html"
            })
            .when("/estudiantes/create", {
                controller: "estudiantecontroller",
                templateUrl: "../../app/views/CreateEstudiante.html"
            })
            .when("/estudiantes/:Estudiante_id", {
                controller: "estudiantecontroller",
                templateUrl: "../../app/views/ViewEstudiante.html"
            })
            .when("/estudiantes/edit/:Estudiante_id", {
                controller: "estudiantecontroller",
                templateUrl: "../../app/views/EditEstudiante.html"
            })
    });