app.controller("CadastroCtrl", function ($http, $scope) {
    $scope.cadastrar = function () {
        $scope.message = "Enviando para a Base de Dados";

        $http.post("https://localhost:44325/api/livro/cadastrar",
            $scope.livro
        ).then(function (data) {
            $scope.message = "Salvo";
            $scope.livro = {};
        }).catch(function (e) {
            $scope.message = "Ocorreu um erro: " + e.status;
        })
    }
})