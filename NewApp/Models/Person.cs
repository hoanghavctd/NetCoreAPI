namespace NewApp.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public void EnterData()
        {
            System.Console.Write("Ho va ten = ");
            FullName = Console.ReadLine();
            System.Console.Write("Dia chi = ");
            Address = Console.ReadLine();
            System.Console.Write("Tuoi = ");
            Age = Convert.ToInt16(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine("Thong tin vua nhap: {0} - {1} - {2}", FullName, Address, Age);
        }
        public void Display1()
        {
            System.Console.WriteLine("Thong tin: {0} - {1}", FullName, Age);
        }
        
    }  
}

