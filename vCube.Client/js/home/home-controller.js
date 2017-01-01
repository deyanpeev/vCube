(function () {
    'use strict';

    function HomeController(virtualMachines) {
        var vm = this;

        virtualMachines.getVms()
            .then(function (virtualMachines) {
                vm.virtualMachines = virtualMachines;
            });
    }

    angular.module('myApp')
        .controller('HomeController', ['virtualMachines', HomeController])
    
}());