﻿(function () {
    'use strict';

    function HomeController(statistics, trips, drivers, virtualMachines) {
        var vm = this;

        statistics.getStats()
            .then(function (stats) {
                vm.stats = stats;
            });

        trips.getPublicTrips()
            .then(function (publicTrips) {
                vm.trips = publicTrips;
            });

        drivers.getPublicDrivers()
            .then(function (publicDrivers) {
                vm.drivers = publicDrivers;
            });

        virtualMachines.getVms()
            .then(function (virtualMachines) {
                vm.virtualMachines = virtualMachines;
            });
    }

    angular.module('myApp')
        .controller('HomeController', ['statistics', 'trips', 'drivers', 'virtualMachines', HomeController])
    
}());