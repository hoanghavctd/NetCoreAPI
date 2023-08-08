namespace NewApp.Models
{
    public class Student
    {
        public string HT { get; set;}
        public string DC { get; set;}
        public int T { get; set;} 
        public String SDT { get; set;}
        public void EnterData()
        {
            System.Console.Write("Ho va ten = ");
            HT = Console.ReadLine();
            System.Console.Write("Dia chi = ");
            DC = Console.ReadLine();
            System.Console.Write("Nam sinh = ");
            T = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("So dien thoai = ");
            SDT = Console.ReadLine();
        }
        public void Display()
        {
            System.Console.WriteLine("Thong tin vua nhap: {0} - {1} - {2} - {3}", HT, DC, T, SDT);
        }
    }  
}