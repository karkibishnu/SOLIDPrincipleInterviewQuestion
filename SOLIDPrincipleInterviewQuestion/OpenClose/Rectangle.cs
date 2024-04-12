namespace SOLIDPrincipleInterviewQuestion.OpenClose
{
    public class Rectangle : shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
