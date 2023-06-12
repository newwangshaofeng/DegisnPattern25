namespace BuilderDemo;

public class House
{
    public string Walls { get; set; }
    public string Roof { get; set; }
    public string Doors { get; set; }
    public string Windows { get; set; }

    public  void Display(){
        Console.WriteLine("Walls:{0}",Walls);
        Console.WriteLine("Roof:{0}",Roof);
        Console.WriteLine("Doors:{0}",Doors);
        Console.WriteLine("Windows:{0}",Windows);
    }
            
}