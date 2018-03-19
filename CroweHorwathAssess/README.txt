Crowe coding exercise-this should take no more than 15-20 minutes.


Assessement Requirements:

Write a ‘Hello World’ program.

a.         The program has 1 current business requirement – write “Hello World” to the console/screen.

b.         The program should have an API that is separated from the program logic to eventually support mobile applications, web applications, or console applications, or windows services.

c.         The program should support future enhancements for writing to a database, console application, etc.

i.          Use common design patterns (inheritance, e.g.) to account for these future concerns.

ii.         Use configuration files or another industry-standard mechanism for determining where to write the information to.

Write unit tests to support the API.


a.  AngularJS sends the business requirement to the screen via AngularJS controller=> AngularJS factor => WebApi => C# Data Service => C# repo =>  Entity Framework => SQL dB

b.  Web Api is implemented in the MessageController class.  The only method would take in a source type.  Different controllers for different apps / concepts would allow for extension.  

c.  SQL Database available in App_Data folder, Console App could use Local DB if occasionally connected or Server side storage for always connected.

i.  Repository Base is a simple abstract class to implement base functionality via virtual methods and abstract methods to force individual implmentation.  Derived Classes could be extended via Interface for abstracts and CRUD.

ii.  AngularJS uses service and controller to bind the front end via javascript functions.

Unit Tests show testing, but will need time to abstract away implementation of EF connection string to get them to run without a local copy of the dB.  The location of the project will need to be set in the App.config connection string





