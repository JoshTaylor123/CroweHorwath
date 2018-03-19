//-----------------------------------------------------------
//Attach Controller to module
//-----------------------------------------------------------
angular.module('app-js')
    .controller('greetingController', ['$scope', '$http', 'webApi', greetingController]);
//-----------------------------------------------------------
//Define Controller
//-----------------------------------------------------------
function greetingController($scope, $http, webApi) {

    var vm = this;
    //-----------------------------------------------------------
    //Public Properties
    //-----------------------------------------------------------
    $scope.greeting = {};


    //-----------------------------------------------------------
    //BROADCAST PUBLISH 
    //-----------------------------------------------------------

    //-----------------------------------------------------------
    //BROADCAST SUBSCRIBE
    //-----------------------------------------------------------

    //-----------------------------------------------------------
    //Web Api Methods
    //-----------------------------------------------------------
    //Time save - ideally the type would be set and passed to the front end
    vm.getGreeting = function () {
        //Make Web Api Request
        webApi.greeting.getGreeting("1")
               .then(function (response) {
                   //Success
                   ///Write Data
                   angular.copy(response.data, $scope.greeting);
               }, function (error) {
                   //Failure
                 
               })
               .finally(function () {
                   //Finalize
                  
               });
    };

    //-----------------------------------------------------------
    //Constructor
    //-----------------------------------------------------------
    vm.load = function () {
        vm.getGreeting();
    };
    vm.load();
};