Create a car dealership application that allows users to add new cars through a nicely-formatted web interface.


Make sure the Car class is well-tested. Try including both public properties and a private field.



Car()
string make {get; set;}
string model {get; set;}
int year {get; set;}
int Id{get;}

public static Car Find (int searchId)




Think carefully about how to use a static property to track all cars that have been created. In the To Do List example, we added Items to a list using the keyword this. For this exercise, we are dealing with Cars instead. How should we declare _instances in this case? What kind of data type should we use?