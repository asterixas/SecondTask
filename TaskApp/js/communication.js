app.controller('taskController', [
    '$scope',
    function ($scope, TaskLoadService) {
      
        $scope.tasks = TaskLoadService.tasks;

    }
]);