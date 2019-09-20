This is a simple service that provides information about the eight planets of the solar system. The solution is called ‘PlanetServices’ and it is split into 3 parts – PlanetServices, PlanetServices.Data and PlanetClient.

Planet Services :
This acts as the API side of the application. It calls PlanetServices.Data for its data and routes it to PlanetClient when an API call is made. 
The heart of this service lies in the planet controller. It contains a simple constructor and two separate get methods, where one returns the entire list of planets and the other returns a specific planet based on the id provided. For the purposes of this project we are only using the method that returns the entire list (IEnumerbale of Planets)
This get method calls the GetAllPlanets() method from the IPlanetRepository (PlanetServices.Data), which will return a list of Planets defined in the PlanetRepository.
Note that we are not hard coding which implementation of planet repository to use, but rather we are using a constructor to set the value of planets (of type IPlanetRepository). This is an example of dependency injection. In this case I am using a dependency injection framework called ‘StructureMap’, which injects a specific implementation of the interface when the interface is called. Or in other words it maps a given interface to the required implementation of the interface.  

PlanetServices.Data :
It is generally considered good practice to split the data layer from the functional layer. In this case the data layer is a simple class library which contains three separate folders – Models, Interfaces and Repositories.
The Models folder contains the ‘Planets.cs’ class which essentially defines the structure of the object. As a general practice it mimics the structure of the table in the database and is usually called the entity class.
The Interfaces folder has one interface IPlanetRepository, which has two methods in it - GetAllPlanets and GetPlanet. 
The Repositories folder has a class called PlanetRepository which implements IPlanetRepository. This class holds all the data used in this project, which is a list of Planets objects.


PlanetClient :
This acts a basic client that calls the Web API using the getasync method and displays the results to the user. I have used Razar to do styling of this data. Please view PlanetsController in PlanetClient to view the implementation.

To Run :
Please run Planetservices first and then run PlanetClient. The API endpoint in PlanetsController (PlanetClient) which is calling PlanetServices needs to be updated to the appropriate port number for the solution to work as expected.

