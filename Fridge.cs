namespace Sims;

public class Fridge : InteriorItem
{
    public Fridge() : base("Fridge")
    {
        
    }

    public void GetFood()
    {
        Console.WriteLine("Yum yum, this is some good food");
    }
}