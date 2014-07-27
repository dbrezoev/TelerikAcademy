/// <reference path="Libs/jquery-2.1.1.js" />
/// <reference path="Libs/sammy-0.7.4.js" />
/// <reference path="Modules/Controller.js" />
(function () {
    'use strict';

    require.config({
        paths: {
            jquery: 'Libs/jquery-2.1.1',
            sammy: 'Libs/sammy-0.7.4',
            Q: 'Libs/q'
        }
    });

    require(['jquery', 'sammy', 'Modules/Controller'], function ($, Sammy, controller) {
       
        
        controller.controlUserInteraction();

        var app = Sammy('#main', function () {
            this.get("#/", function () {
                $('#main').load('Views/UserLogIn.html');               
            });

            this.get("#/chatroom", function () {
                $('#main').load('Views/ChatRoom.html');
            });
            
        });
        $(function () {
            app.run('#/');
        })
        
    });
}());