// dotnet add package MySql.EntityFrameworkCore
namespace IntroEntityFramework.Models;

public class Computer
{
    public int Id {get; set;}
    public string Ram {get; set;}
    public string Processor {get; set;}
    public Computer(int id, string ram, string processor)
    {
        Id = id;
        Ram = ram;
        Processor = processor;
    }
}