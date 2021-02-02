angular.module("EscuelaApp")
    .factory('Estudiantes', ['$resource', function ($resource) {
        return $resource('https://localhost:44341/api/Estudiante/:estudiante_id', {
            estudiante_id: '@estudiante_id'
        }, {
            update: {
                method: 'PUT'
            },
                delete: {
                    method: 'DELETE',
                    params: { estudiante_id: '@estudiante_id'}
                }
        });
    }]);