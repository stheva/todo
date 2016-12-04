angular.module("todolist", ["ngRoute"]).
    config(["$routeProvider", function ($routeProvider) {
        $routeProvider.when('/todolist', { templateUrl: '/templates/todolist.html', controller: 'TodoListController' });
        $routeProvider.when('/todoedit/:id', { templateUrl: '/views/todoedit.html', controller: 'TodoEditController' });
        $routeProvider.when('/todocreate', { templateUrl: '/views/todocreate.html', controller: 'TodoCreateController' });
        $routeProvider.otherwise({ redirectTo: '/todolist' });
    }]);