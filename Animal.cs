namespace prelim_exam
{
    public abstract class Animal
    {
        //TODO: Modify this class so that we can set _class ONLY ONCE 
        string _class;
        //TODO: Modify this class so that we can set _ofType ONLY ONCE
        //_ofType sample: Bird, Fish, Mammal -- all these classes are already provided
        string _ofType;
        //TODO: Modify so that we can set number of legs ONLY ONCE
        //TODO: Must expose the value of _numberOfLegs but not the variable OUTSIDE the class
        int _numberOfLegs;


        //Note: This is a auto-implemented getter-setter
        public bool CanSwim { get; set; }
        public string Name { get; set; }

        public string GetClass();
        public string OfType();
        public bool HasLegs() _numberOfLegs > 0;
    }
}
