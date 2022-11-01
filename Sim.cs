namespace Sims;

public class Sim
{
    private String Name = "Unknown";
    private bool Adult = true;
    List<Sim> FamilyMembers { get; set; }

    public Sim(string name)
    {
        Name = name;
    }
    public void InteractWithFamilyMember()
    {

    }
    
}