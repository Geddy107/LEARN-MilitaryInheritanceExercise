using System;

namespace InheritanceProject
{
    public class Vehicles : TwoFiveOEight
    {

        public string name;
        public int capacity;
        public string fuelType;
        public bool landVehicle;

        public virtual void startUp()
        {
            Console.WriteLine("*Start Noise*");
        }

        public virtual void turnOff()
        {
            Console.WriteLine("* Winding down *");
        }

        public Vehicles(string nm, int cap, string fuel, bool lVeh)
        {
            name = nm;
            capacity = cap;
            fuelType = fuel;
            landVehicle = lVeh;


        }



    }

    class Appache : Vehicles
    {
        public Appache() : base("Appache", 2, "JP-8", false)
        { }

        public override void startUp()
        {
            Console.WriteLine("Rotars whinning");
        }

        public override void turnOff()
        {
            Console.WriteLine("Rotars whinning down");
        }

    }

    class blackHawk : Vehicles
    {
        public blackHawk() : base("Black Hawk", 7, "JP-8", false)
        { }

        public override void startUp()
        {
            Console.WriteLine("Rotars whinning");
        }

        public override void turnOff()
        {
            Console.WriteLine("Rotars whinning down");
        }

    }

    class M1Abrams : Vehicles
    {
        public M1Abrams() : base("M1A2 Abrams", 5, "JP-8, Gasoline, Diesel ", true)
        { }

        public override void startUp()
        {
            Console.WriteLine("Spooling Up");
        }



    }

    class LMTV : Vehicles
    {
        public LMTV() : base("LMTV", 19, "Diesel", true)
        { }

        public override void startUp()
        {
            Console.WriteLine("Engine turning over");
        }

        public override void turnOff()
        {
            Console.WriteLine("Engine shuts down");
        }

    }










}

