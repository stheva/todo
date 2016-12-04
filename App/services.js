var services = angular.module('todolist.services', ["ngResource"]);

services.factory('TodosFactory', function ($resource) {
    return $resource('/api/todos',
        {},
        {
            query: { method: 'GET', isArray: true },
            create: { method: 'POST' }
        });
});

services.factory('TodoFactory', function ($resource) {
    return $resource('/api/todos/:id',
        {},
        {
            show: { method: 'GET' },
            update: { method: 'PUT', params: { id: '@id' } },
            delete: { method: 'DELETE', params: { id: '@id' } }
        });
});