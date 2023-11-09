public abstract class Bird
{
    public string Name { get; set; }

    public Bird(string name)
    {
        Name = name;
    }
}

// Клас для птахів, які літають
public class FlyingBird : Bird
{
    public FlyingBird(string name) : base(name) { }
}

// Клас для птахів, які плавають
public class SwimmingBird : Bird
{
    public SwimmingBird(string name) : base(name) { }
}

// Клас для птахів, які бігають
public class RunningBird : Bird
{
    public RunningBird(string name) : base(name) { }
}
public interface IAviary
{
    double CalculateArea(); // Функція для обчислення площі вольєру
}

// Клас для вольєрів з сіткою для літаючих птахів
public class FlyingAviary : IAviary
{
    public double Width { get; set; }
    public double Length { get; set; }

    public FlyingAviary(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public double CalculateArea()
    {
        return Width * Length;
    }
}

// Клас для вольєрів з озером для плаваючих птахів
public class SwimmingAviary : IAviary
{
    public double Width { get; set; }
    public double Length { get; set; }


    public SwimmingAviary(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public double CalculateArea()
    {
        return Width * Length;
    }

}

// Клас для вольєрів з огорожею для бігаючих птахів
public class RunningAviary : IAviary
{
    public double Width { get; set; }
    public double Length { get; set; }

    public RunningAviary(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public double CalculateArea()
    {
        return Width * Length;
    }
}