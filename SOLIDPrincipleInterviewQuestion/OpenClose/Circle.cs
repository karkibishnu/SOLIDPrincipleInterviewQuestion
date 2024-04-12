namespace SOLIDPrincipleInterviewQuestion.OpenClose
{
    //Concrete shape classes (Rectangle and Circle) inherit from the abstract shape class
    //and provide their own implementations of the Area() method.
    //Each shape class encapsulates its own data and behavior related to calculating its area.
    public class Circle : shape
    {
        public double Radius { get; set; } //data or fields
        public override double Area() //behavior or properties
        {
            return Radius * Radius * Math.PI;
        }
    }
}
