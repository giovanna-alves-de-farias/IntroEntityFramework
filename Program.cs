//dotnet run
using IntroEntityFramework.Models;

SystemContext context = new SystemContext();

context.Database.EnsureCreated();

// Computer c1 = new Computer(1, "2GB", "i3");
// context.Computers.Add(c1);
// context.SaveChanges();

// Computer c2 = new Computer(2, "5GB", "i5");
// context.Computers.Add(c2);
// context.SaveChanges();

// Computer c3 = new Computer(3, "7GB", "i7");
// context.Computers.Add(c3);
// context.SaveChanges();

IEnumerable<Computer> computers = context.Computers.ToList();

foreach(var item in computers)
{
    Console.WriteLine($"{item.Id}, {item.Ram}, {item.Processor}");
}

Computer encontrado = context.Computers.Find(2);
Console.WriteLine($"{encontrado.Id}, {encontrado.Ram}, {encontrado.Processor}");

encontrado.Ram = "20GB";
encontrado.Processor = "amd";
context.Computers.Update(encontrado);
context.SaveChanges();

context.Computers.Remove(encontrado);
context.SaveChanges();