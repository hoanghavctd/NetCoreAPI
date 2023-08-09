﻿using NewApp.Models;
public class Program
{ 
    private static void Main(string[] args)
    {
        /*
        Person ps1 = new Person();
        ps1.EnterData();
        ps1.Display();
        Employee ps2 = new Employee();
        ps2.EnterData();
        ps2.Display();
       */ 
        Student ps3 = new Student();
        ps3.EnterData();
        ps3.Display();
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        gpt.GiaiPhuongTrinhB1();
    }
}