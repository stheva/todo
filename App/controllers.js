var app = angular.module('todolist.controllers', []);

app.controller('TodoListController', ['$scope', 'TodosFactory', 'TodoFactory', '$location',
    function ($scope, TodosFactory, TodoFactory, $location) {

        // callback for ng-click 'editTodo':
        $scope.editTodo = function (todoId) {
            $location.path('/todoedit/' + todoId);
        };

        // callback for ng-click 'deleteTodo':
        $scope.deleteTodo = function (todoId) {
            TodoFactory.delete({ id: todoId });
            $scope.todos = TodosFactory.query();
        };

        // callback for ng-click 'createTodo':
        $scope.createNewTodo = function () {
            $location.path('/todocreate');
        };

        $scope.todos = TodosFactory.query();
    }]);

app.controller('TodoEditController', ['$scope', '$routeParams', 'TodoFactory', '$location',
    function ($scope, $routeParams, TodoFactory, $location) {

        // callback for ng-click 'updateTodo':
        $scope.updateTodo = function () {
            TodoFactory.update($scope.todo);
            $location.path('/todolist');
        };

        // callback for ng-click 'cancel':
        $scope.cancel = function () {
            $location.path('/todolist');
        };

        $scope.todo = TodoFactory.show({ id: $routeParams.id });
    }]);

app.controller('TodoCreateController', ['$scope', 'TodosFactory', '$location',
    function ($scope, TodosFactory, $location) {

        // callback for ng-click 'createNewTodo':
        $scope.createNewTodo = function() {
            TodosFactory.create($scope.todo);
            $location.path('/todolist');
        };
    }]);