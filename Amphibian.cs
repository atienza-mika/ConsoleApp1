using System;

namespace prelim_exam
{
    public class Amphibian : Animal, IPrintAnimalName
    {
        public override string GetClass();



        public override string OfType();

        public void PrintAnimalName ()
        {
            Console.WriteLine(this.Name);

        }
        
    }
    public interface IPrintAnimalName
    {
        void PrintAnimalName ();
    }



    public class Frog : Amphibian
    {
        public string Name { get; set; }
    }
    public class Salamander : Amphibian
    {
        public string Name { get; set; }
    }

}
