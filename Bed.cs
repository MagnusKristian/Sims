namespace Sims;

public class Bed : InteriorItem 
{
    public Bed() : base("Bed")
    {
        
    }

    public void Woohoo()
    {
        Console.WriteLine("You dirty dog");
    }

    public void Sleep()
    {
        Console.WriteLine("Good night!");
    }
}