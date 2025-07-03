/*
 * Skapa en klass Produkt med egenskaperna Namn (string) och Pris (double).
 * Lägg till en metod VisaInfo() som skriver ut produktens namn och pris.
 * I Main(), skapa minst två produkter och skriv ut deras information. */
using System;
class Program
{
    static void Main()
    {
        Produkt dricka = new Produkt();
        dricka.Namn = "Kaffe";
        dricka.Pris = 15.50;   //why does this info not show?

        Produkt kaka = new Produkt();
        kaka.Namn = "Kladdkaka";
        kaka.Pris = 23.70;

        Console.WriteLine("Skriv in produktens namn: ");

        Produkt produkt = new Produkt();
        produkt.Namn = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Skriv in produktens pris:");
        double prisbd = Convert.ToDouble(Console.ReadLine());  //Convert.ToDouble cant handle exceptions problematic with user input try: double.TryParse()?
        produkt.Pris = prisbd;

        Console.Clear();
        Console.WriteLine("Tryck för att se produkt och pris:"); //doesn't wait for a button to be pressed to show info

        produkt.VisaInfo(); // Should probably figure out how to store info (in list so next assignement?

    }
    public class Produkt
    {
        public string Namn;
        public double Pris;
        public void VisaInfo()
        {
            Console.WriteLine(Namn + " " + Pris + " kr");
        }

    }
}