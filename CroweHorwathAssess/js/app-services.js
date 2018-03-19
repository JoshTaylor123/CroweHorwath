(function () {
    //----------------------------------------------- script globals

    "use strict";
    var app = angular.module('app-js');
    //-----------------------------------------------
    //WEB API CALLS
    //-----------------------------------------------
    app.factory('webApi',
        ['$http',
            function ($http) {

                return {
                    greeting: {
                        getGreeting: function (sourceTypeID) {
                            return $http({ method: 'GET', url: '/message/Greeting', params: { sourceTypeID: sourceTypeID } })
                        }
                    }
                }
            }
        ]);
}());