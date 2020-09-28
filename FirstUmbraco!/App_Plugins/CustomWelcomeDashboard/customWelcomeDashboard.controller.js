angular.module("umbraco")
    .controller("CustomWelcomeDashboardController",
        function ($scope, userService, logResource, entityResource) {
            var vm = this;
            vm.UserName = "guest";
            vm.UserLogHistory = [];

            var user = userService.getCurrentUser().then(function (user) {
                console.log(user);
                vm.UserName = user.name;
            });

            var userLogOptions = {
                pageSize: 10,
                pageNumber: 1,
                orderDirection: "Descending",
                sinceDate: new Date(2020, 0, 1)
            };
        });