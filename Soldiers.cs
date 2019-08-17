using System;

namespace InheritanceProject
{
    public class Soldiers : TwoFiveOEight
    {
       public string name;
       public string fuelType = "MRE";
       public string says;
       public bool leg;

        public virtual void Loadout()
        {
            Console.WriteLine("Standard loadout, 7 fully loaded mags and 4 quarts of water");
        }

        public virtual void Speak()
        {
            Console.WriteLine("HOOAH");
        }

        public Soldiers(string nm, bool lg, string say)
        {
            name = nm;
            leg = lg;
        }
    }


    class S1 : Soldiers
    {
        public S1() : base("S1", true, "I lost your paperwork")
        { }
        public override void Loadout()
        {
            Console.WriteLine("1000 reams of paper");
        }
    }


    class Medic : Soldiers
    {
        public Medic() : base("68W", true, "Have you been to sickcall?")
        { }
        public override void Loadout()
        {
            Console.WriteLine("MedPack");
        }

    }

    class FirstSergeant : Soldiers
    {
        public FirstSergeant() : base("First Sergeant", false, "No you can't go on leave")
        { }
        public override void Loadout()
        {
            Console.WriteLine("1000 rounds of ammo and a can of dip");
        }

    }

    class S6 : Soldiers
    {
        public S6() : base("S6", true, "Have you tried restarting it?")
        { }
        public override void Loadout()
        {
            Console.WriteLine("Commo Equipment");
        }

    }







}
 
