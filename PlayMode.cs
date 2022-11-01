namespace Sims;

public class PlayMode
{
    public Room CurrentRoom { get; set; }
    public Sim Player { get; set; }
    public void EnterRoom(Room newRoom)
    {
        CurrentRoom = newRoom;
    }
    public void ExamineRoom()
    {
        Console.WriteLine($"This is what's inside this room: ");
        CurrentRoom.ShowFurniture();
    }
    public void ShowMenu()
    {

    }
}