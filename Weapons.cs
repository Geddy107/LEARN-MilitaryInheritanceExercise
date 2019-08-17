using System;

namespace InheritanceProject
{
    public class Weapons : TwoFiveOEight
    {

        public bool handheld;
        public string name;
        public string caliber;
        public int ammoCap;


        public virtual void Reload()
        {
            Console.WriteLine("Chick Chick");
        }
        public virtual void Fire()
        {
            Console.WriteLine("Bang");
        }

        public Weapons(string nm, string cal, int cap, bool hndHeld)
        {
            name = nm;
            caliber = cal;
            ammoCap = cap;
            handheld = hndHeld;


        }
    }

        class M9 : Weapons
        {
            public M9() : base("M9 Berreta", "9mm", 15, true)
            { }

            public override void Fire()
            {
                Console.WriteLine("pew");
            }


        }

        class P226 : Weapons
        {
            public P226() : base("Sig P226", "9mm", 15, true)
            { }

            public override void Fire()
            {
                Console.WriteLine("pew");
            }

            public void Decock()
            {
                Console.WriteLine("Decock");
            }


        }

        class Glock19 : Weapons
        {
            public Glock19() : base("Glock 19", "9mm", 15, true)
            { }

            public override void Fire()
            {
                Console.WriteLine("pew");
            }


        }

        class Moss590 : Weapons
        {
            public Moss590() : base("Mossberg 590A1", "12GA", 6, true)
            { }

            public override void Reload()
            {
                Console.WriteLine("Thump, thump, thump");
            }


        }

        class M4 : Weapons
        {
            public M4() : base("Colt LE6920", "5.56 x 45", 30, true)
            { }

            public override void Fire()
            {
                Console.WriteLine("Rata-tat-tat");
            }

            public override void Reload()
            {
                Console.WriteLine("Chick thump");
            }


        }

        class SupRem : Weapons
        {
            public SupRem() : base("Supressed Remington 870", ".308", 6, true)
            { }

            public override void Fire()
            {
                Console.WriteLine("Quiet bang");
            }

            public override void Reload()
            {
                Console.WriteLine("Click, click, click");
            }

        }

        class M2 : Weapons
        {
            public M2() : base("Ma Duce", ".50 Cal", 50, false)
            { }

            public override void Fire()
            {
                Console.WriteLine("BANG, BANG, BANG");
            }

            public override void Reload()
            {
                Console.WriteLine("THUNK, THUNK");
            }

        }

        class M19 : Weapons
        {
            public M19() : base("Mark 19 Grenade Launcher", "40mm", 25, false)
            { }

            public override void Fire()
            {
                Console.WriteLine("THUMP, THUMP, THUMP");
            }

            public override void Reload()
            {
                Console.WriteLine("THUNK, THUNK");
            }

        }
    










}
 
