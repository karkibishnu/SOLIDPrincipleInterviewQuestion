
using SOLIDPrincipleInterviewQuestion;
using SOLIDPrincipleInterviewQuestion.DependencyInversion;
using SOLIDPrincipleInterviewQuestion.LiskovSubstitution;
using SOLIDPrincipleInterviewQuestion.OpenClose;
using Circle = SOLIDPrincipleInterviewQuestion.OpenClose.Circle;

Console.WriteLine("Hello, World!");

//example usage for openclose
var shapes = new shape[]
{
    new Rectangle { Width = 5, Height = 10 },
    new Circle { Radius = 3}
};

double totalArea = AreaCalculator.GetTotalArea(shapes);
Console.WriteLine($"Total Area: {totalArea}");


//example usage for liskov substitution
//Shape is a base class, and Circle and Square are subclasses inheriting from Shape.
//Each subclass overrides the Area() method to calculate the area specific to its shape.

// the Liskov Substitution Principle states that objects of a superclass should be
// replaceable with objects of its subclasses without affecting the correctness of the program.
// This means that wherever you expect a Shape object, you should be able to replace it with a
// Circle or Square object without any issues.
Shape liskovCircle = new LiskovCircle(5);
Shape liskovSquare = new LiskovSquare(5);

//In the Main method, you can see that we're able to pass both a Circle object and a Square object
//to the PrintShapeArea method, which expects a Shape object. This demonstrates the Liskov Substitution
//Principle in action. Regardless of whether we pass a Circle or Square, the program behaves
//correctly and prints the respective areas.

PrintArea.PrintShapeArea(liskovCircle);
PrintArea.PrintShapeArea(liskovSquare);


//DIP - Depedency Inversion Principle
// the Notification class isn't directly tied to specific implementations of messaging services,
// making it more adaptable and conformant to the Dependency Inversion Principle.
//usage example
Email email = new Email();
email.ToAddress = "example@example.com";
email.Subject = "Subject";
email.Content = "Content";

Notification emailNotification = new Notification(email);
emailNotification.Send(); //sends email

SMS sms = new SMS();
sms.Message = "Hello SMS";
sms.PhoneNumber = "1234567890";

Notification smsNotification = new Notification(sms);
smsNotification.Send();