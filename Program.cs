using System;
using RPG.src.Entities;

namespace RPG 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Clarice", 23, "Wizard");



            Console.Write(hero.ToString());
            Console.Write(hero.Attack());
        }
    }
}




