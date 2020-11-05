using System;
using System.Collections.Generic;

namespace prelim_exam
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Amphibians = { "Frog", "Salamander", "Amphiuma" };
            string[] Fish = { "Milkfish", "Goldfish", "Salmon" };
            string[] Bird = { "Crow", "Dove", "Pigeon" };
            string[] Mammal = { "Giraffe", "Deer", "Horse" };
           
           foreach(var l in listOfAnimals)
            {
                if ($ is Fish || $ is Mammal || $ is Bird)
                {
                    Console.WriteLine($.Name);
                }
            }  
           
           foreach(IPrintAnimalName a in listOfAnimals)
            {
                if(a is IPrintAnimalName)
                {
                    a.PrintAnimalName();
                    var temp = (a as Animal).Name; 
                }
            }
        }
    }
}
