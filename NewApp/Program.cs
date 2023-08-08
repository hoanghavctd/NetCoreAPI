using NewApp.Models;
public class Program
{ 
    private static void Main(string[] args)
    {
        Person ps1 = new Person();
        ps1.EnterData();
        ps1.Display();
        Person ps2 = new Person();
        ps2.FullName = "Ho ten mac dinh";
        ps2.Address = "Dia chi mac dinh";
        ps2.Age = 33;
        ps2.Display();
    }
}