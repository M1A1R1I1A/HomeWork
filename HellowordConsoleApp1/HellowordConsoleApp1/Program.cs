using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HellowordConsoleApp1
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello world!");


            // Console.WriteLine(2 * 2 + 2);

            // int a = 150;
            // int b = 50;
            // int c = a + b;
            //  Console.WriteLine(c);
              
            
                //1.
             string fullName = "Matevosyan Maria Artashesi";
             byte age = 23;
             string email = "matevosyanmaria@mail.ru";
            double programmingScores = 0;
             double mathematicsScores = 19.5;
             double physicsScores = 15;

             Console.WriteLine(" Fullname: " + fullName + " Age: " + age + " email: " + email);
             Console.WriteLine(" Programming Score: " + programmingScores + " , Mathematics Score: " + mathematicsScores + " , Physics Scores: " + physicsScores);

                //2.
            double programmingScores = 0;
            double mathematicsScores = 19.5;
            double physicsScores = 15;
            double score = programmingScores + mathematicsScores + physicsScores;
            double averageScore = (programmingScores + mathematicsScores + physicsScores) / 3;

             Console.WriteLine(" Score: " + score);
             Console.WriteLine(" AverageScore: " + averageScore );


            //   string name = "Maria";
            //   byte age = 23;

            //  Console.WriteLine("Enter the name: ");
            //  name =  Console.ReadLine();

            //  Console.WriteLine("Enter the age: ");
            //   age =  byte.Parse(Console.ReadLine());

            //  Console.WriteLine("Name: " + name + " Age: " + age);



            //Random randomize = new Random();

            //int randomIntResult = randomize.Next();

            //Console.WriteLine($"PRIMER 1. randomIntResult = {randomIntResult}");

            //randomIntResult = randomize.Next(100);

            // Console.WriteLine($"PRIMER 2. randomIntResult = {randomIntResult}");

            // randomIntResult = randomize.Next(200, 300);

            // Console.WriteLine($"PRIMER 3. randomIntResult = {randomIntResult}");


            //double randomDoubleResult = randomize.NextDouble() * 10;

            //Console.WriteLine($"PRIMER 4. randomDoubleResult = {randomDoubleResult}");



            // Random rand = new Random();

            //  int temperature = rand.Next(45);
            // Console.WriteLine($"TEMPERATURE = {temperature}°C");

            //  if (temperature < 18)
            //  {
            //      Console.WriteLine("IT'S COLD OUTSIDE");               
            //  }
            //  else
            //  {
            //       Console.WriteLine("IT'S WARM OUTSIDE");
            //  }



            Console.ReadKey();

















        }





    }
}
 