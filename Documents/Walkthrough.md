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