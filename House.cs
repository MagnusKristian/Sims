namespace Sims;

public class House
{
    List<Floor> Floors { get; set; }
    public House()
    {
        Floors = new List<Floor>();
        Floors.Add(new Floor());
    }

    public Floor GetFirstFloor()
    {
        return Floors[0];
    }

}