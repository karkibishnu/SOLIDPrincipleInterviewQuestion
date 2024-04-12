namespace SOLIDPrincipleInterviewQuestion
{
    //An abstract shape class is introduced, which defines a common interface for different types of shapes.
    public abstract class shape
    {
        //The Area() method is declared as abstract, forcing concrete shape classes
        //to implement their own area calculation logic
        public abstract double Area();
    }
}
