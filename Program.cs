using System;
using System.Collections.Generic;
using System.IO;
public class Program
{
    public static void Main(string[] args)
    {   
        Console.WriteLine("Hello and welcome to the Pie MachineTM!");
        Console.WriteLine("Here we give inspiration for cooking with berries and fruits! :)");
        Console.WriteLine("Let's get inspired!");

        string tsekkaus = File.ReadAllText("fruits.txt"); 
        Reseptit ohjeet = new Reseptit();

        while (true) // ohjelma kysyy mitä marjoja/hedelmiä käyttäjällä on
        {
            Console.WriteLine("What berries or fruits do you have in your fridge?:");
            string fruit = Console.ReadLine();

            if (fruit == "")
            {
                continue;          // jos syöte on tyhjä, kysyy ohjelma uudestaan kysymyksen
            }
            
            if (tsekkaus.Contains(fruit)) //ohjelma tarkistaa, löytyykö syötettä listauksesta ja hakee ohjeet ja tulostaa nämä
            {
                string recipe = ohjeet.GetRecipe(fruit);
                Console.WriteLine(recipe);

                while (true) // ohjelma kysyy halutaanko jatkaa vai lopettaa
                {
                    Console.WriteLine("Are you in need of more inspiration?(yes/no)");
                    string again = Console.ReadLine();

                    if (again == "yes")
                    {    
                        break;
                    }
                    else if (again == "no") // ohjelma kiittää käytöstä ja laskee kuinka monta kertaa reseptit haettiin
                    {
                        int amount = ohjeet.GetUsage();
                        Console.WriteLine("Thank you for using The Pie MachineTM!\n" + "You got insprided " + amount + " time(s)!\n" + "Happy cooking!<3");
                        return;
                    }
                    else // ohjelma pitää huolen vain hyväksyttävistä syötteistä
                    {
                         Console.WriteLine("That wasn't a yes or a no, please try again!");
                    }
                }
            }
            else 
            {
                Console.WriteLine("We are at our beta testing phase, and unfortunately don't yet have inspiration for that, try again!");
                continue; // jos marjaa/hedelmää ei löyty listauksesta, kysyy ohjelma sopivaa syötettä uudestaan
            }
            

        }
        
    }
}

