app.config(function ($routeProvider) {
    $routeProvider
        .when("/cadastro", {
            templateUrl: "/app/views/Livro/cadastro.html",
            controller: "CadastroCtrl"
        })
        .when("/consulta", {
            templateUrl: "/app/views/Livro/consulta.html",
            controller: "ConsultaCtrl"
        })
});

app.config(function ($locationProvider) {
    $locationProvider.hashPrefix('');
});