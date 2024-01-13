How-to Create TestBreakfast WebAPI

1. Create a Class Library (ex. TestBreakfast.Contracts)
    -dotnet new classlib -o <nameOfClassLib.Here>

2. Create a WebAPI Project (ex. TestBreakfast)
    -dotnet new webapi -o <nameOfProject>
    -Name of project and class library should relate and describe each one's relation to the other

3. In class library, create classes that define WebAPI objects
    ex. CreateBreakfastRequest.cs for a class that outlines the characteristics of a Create action (name, description, date, etc.)

4. In project, create a BreakfastsController in the Controller folder (ex. BreakfastController.cs)
    -if you need to add a reference to your class library:
        dotnet add *<ProjectName> reference *<Class.Library>

End of Day 1: Start at 20:46 in Video

5. Create a Model to hold request properties (ex. Breakfast)
    -This allows for the mapping of the data received by the request to language used by application

6. Create object that converts system data back into API Definition (ex. BreakfastResponse)

7. Create an interface to hold Methods that will define behavior of actions (Create, Upsert, Delete, etc.) (ex. IBreakfastService)

8. Create a class to implement the Methods that are defined in the interface

9. Add definition on how to implement interface in Program.cs (builder.Services.LifetimeOfObjectOption<interface, object>)

End of Day 2: Start at 35:41 in Video
    






