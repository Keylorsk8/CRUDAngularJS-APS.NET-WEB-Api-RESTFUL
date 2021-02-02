angular.module("EscuelaApp")
    .controller("estudiantecontroller", ['$scope', '$routeParams', '$location', 'Estudiantes', '$resource',
        function ($scope, $routeParams, $location, Estudiantes, $resource) {
            $scope.create = function () {
                var estudiante = new Estudiantes({
                    Nombre: $scope.estudiante.Nombre,
                    Primer_apellido: $scope.estudiante.Primer_apellido,
                    Segundo_apellido: $scope.estudiante.Segundo_apellido,
                    Edad: $scope.estudiante.Edad
                });

                estudiante.$save(function (response) {
                    $location.path('/estudiantes');
                    toastr.success('¡Estudiante agregado correctamente!')
                }, function (errorResponse) {
                    $scope.error = errorResponse.data.message;
                })
            };

            $scope.find = function () {
                $scope.estudiantes = Estudiantes.query();
            };

            $scope.findOne = function () {
                $scope.estudiante = Estudiantes.get({
                    Estudiante_id: $routeParams.Estudiante_id
                });
                console.log($routeParams.Estudiante_id);
            };

            $scope.update = function () {
                $scope.estudiante.$update(function () {
                    $location.path('/estudiantes');
                    toastr.success('¡Estudiante actualizado correctamente!')
                }, function (errorResponse) {
                    $scope.error = errorResponse.data.message;
                })
            };

            $scope.delete = function (estudiante) {
                //if (estudiante) {
                //    estudiante.$remove(function () {
                //        for (var i in $scope.estudiantes) {
                //            if ($scope.estudiantes[i] === estudiante) {
                //                $scope.estudiantes.splice(i, 1);
                //            }
                //        }
                //    });
                //} else {
                //    $scope.estudiante.$remove(function () {
                //        $location.path('#/estudiantes');
                //    })
                //}
                var r = $resource('https://localhost:44341/api/Estudiante?estudiante_id=' + estudiante.Estudiante_id);
                r.remove();
                for (var i in $scope.estudiantes) {
                    if ($scope.estudiantes[i] === estudiante) {
                        $scope.estudiantes.splice(i, 1);
                    }
                }
                toastr.success('¡Estudiante eliminado correctamente!')
            }
        }
    ]);

