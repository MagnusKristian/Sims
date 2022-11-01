namespace Sims;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public bool IsCurrentlyInARoom { get; set; }

    public Player()
    {
        
    }
}