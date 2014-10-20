app.directive('PlayGameDirective', function() {
    return {
        restrict: 'E',
        template: '<p>Hello {{name}}!</p>',
        controller: function($scope, $element){
            $scope.gameId = $scope.name + "Second ";
        }
    }
})
