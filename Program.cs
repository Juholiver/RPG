// See https://aka.ms/new-console-template for more information
using System;
using DotNetRpg.src.Entities;

namespace DotNetRpg
{
    class Program
    {
        static void Main (string[ ] args)
        {
            Khight Khight = new Khight("Arus", 23, "Knight",1000 , 100);
            Wizard Wizard = new Wizard ("Jennica", 23, "white Wizard", 500 , 1000);
            WizardBlack WB = new WizardBlack ("Jenny", 30, "Black Wizard", 850, 1020);
            Samurai Samurai = new Samurai("Nobunaga", 35, "Samurai",850 , 300);
            
            System.Console.WriteLine(Khight.ToString());
            System.Console.WriteLine(Khight.Attack());
            System.Console.WriteLine(Wizard.ToString());
            System.Console.WriteLine(Wizard.Attack(5));
            System.Console.WriteLine(WB.ToString());
            System.Console.WriteLine(WB.Attack(2));
            System.Console.WriteLine(Samurai.ToString());
            System.Console.WriteLine(Samurai.Attack(8));
            
        }
    }
}
