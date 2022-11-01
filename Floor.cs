namespace Sims;

public class Floor
{
    List<Room> Rooms { get; set; }

    public Floor()
    {
        Rooms = new List<Room>();
    }
    public void AddRoomToFloor(Room roomToAdd)
    {
        Rooms.Add(roomToAdd);
    }
    //just to check what you/i have built (temporary)
    public void PrintRooms()
    {
        foreach (var room in Rooms)
        {
            Console.WriteLine(room.Name);
            Console.WriteLine("With inventory of: ");
            room.ShowFurniture();
        }
    }
}