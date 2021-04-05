
app.controller("ConsultaCtrl", function ($scope, $http) {

    $scope.consultarLivros = function () {
        $http.get("https://localhost:44325/api/livro/listartodos")
            .then(function (response) {
                console.log(response.data)
                $scope.livros = response.data;
            })
            .catch(function (e) {
                $scope.message = e.data;
            })
    }

    $scope.getOneItem = function (id) {
        $http.get("https://localhost:44325/api/livro/obterporid?id=" + id)
            .then(function (response) {
                $scope.livro = response.data;
            })
            .catch(function (e) {
                $scope.message = e.data;
            })
    }

    $scope.excluir = function () {
        $http.delete("https://localhost:44325/api/livro/excluir?id="
            + $scope.livro.CodLivro)
            .then(function (response) {
                $scope.message = response.data;
                $scope.consultarLivros();
            }).catch(function (e) {
                $scope.message = e.data;
            })
    }

    $scope.atualizar = function () {
        $http.put("https://localhost:44325/api/livro/atualizar", $scope.livro)
            .then(function (response) {
               // console.log(response.data);
                $scope.message = response.data;
                $scope.consultarLivros();
            }).catch(function (e) {
                $scope.message = e.data;
                //console.log(JSON.stringify(e.data))
            })
    }
})