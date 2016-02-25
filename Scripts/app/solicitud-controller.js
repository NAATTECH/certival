app.controller('SolicitudCtrl', function ($scope, $http) {

    $scope.title = "Cargando solicitud...";
    $scope.solicitud = {
        id: '',
        nombre: '',
        apellidoPaterno: '',
        apellidoMaterno: '',
        //@" ^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM]{1}(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z]{1}[0-9]{1}$"
        curp: '',
        fechaNacimiento: '',
        genero: '',
        nacionalidad: '',
        correoElectronico: '',
        confirmCorreoElectronico: '',
        domicilio: '',
        telefono: '',
    };


    $scope.working = false;

    $scope.newSolicitud = function () {
        $scope.working = true;
        $scope.title = "Cargando solicitud...";

        $http.get("/api/solicitud").success(function (data, status, headers, config) {
            $scope.solicitud = data;
            $scope.title = "Solicitud cargada";
            $scope.working = false;

        }).error(function (data, status, headers, config) {
            $scope.title = "Oops... algo falló. Contacte al administrador";
            $scope.working = false;
        });
    };

    $scope.sendSolicitud = function () {
        $scope.working = true;
        $scope.title = "Cargando solicitud...";

        $http.post('/api/solicitud', { 'solicitud': $scope.solicitud}).success(function (data, status, headers, config) {
            $scope.title = "Solicitud enviada";
            $scope.working = false;

        }).error(function (data, status, headers, config) {
            $scope.title = "Oops... algo falló. Contacte al administrador";
            $scope.working = false;
        });
    };

});





