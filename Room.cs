namespace Sims;

public class Room
{
    List<InteriorItem> Interior { get; set; }
    public string Name { get; set; }
    public string Id { get; set; }
    
    //muligens liste med folk som er inne i dette rommet nå. List<People> peopleInsideNow??

    public Room(string name, string id)
    {
        Interior = new List<InteriorItem>();
        Name = name;
        Id = id;
        Interior.Add(new Bed());
    }
    public void ShowFurniture()
    {
        if (this.Interior.Count >= 1)
        {
            Console.WriteLine($"Here is the furniture in {this.Name}");
            foreach (var furniture in Interior)
            {
                Console.WriteLine($"{furniture.Name}");
            }
        }
    }
}