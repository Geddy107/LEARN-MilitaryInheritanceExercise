using System;

namespace InheritanceProject
{
    class App
    {
        public void Run()
        {   //Weapons
            Weapons Mnizzle = new M9();
            Weapons P22sizzle = new P226();
            Weapons Glock1nizzle = new Glock19();
            Weapons Mossbizzle590 = new Moss590();
            Weapons Mfizzle = new M4();
            Weapons SupRizzle = new SupRem();

            //Vehicle
            Vehicles Apizzle = new Appache();
            Vehicles Blackdizzle = new blackHawk();
            Vehicles Mwizzle = new M1Abrams();
            Vehicles LMTvizzle = new LMTV();

            //Soldiers
            Soldiers sWizzle = new S1();
            Soldiers medizzle = new Medic();
            Soldiers firstSarizzle = new FirstSergeant();
            Soldiers Ssizzle = new S6();
            //Weapons Display
            Console.WriteLine("Weapons");
            Console.WriteLine("______________________________________________________________________________________________________________");
            Console.WriteLine($"The {Mnizzle.name} fires a {Mnizzle.caliber} and has a {Mnizzle.ammoCap} ammo capacity");
            Console.WriteLine($"The {P22sizzle.name} fires a {P22sizzle.caliber} and has a {P22sizzle.ammoCap} ammo capacity");
            Console.WriteLine($"The {Glock1nizzle.name} fires a {Glock1nizzle.caliber} and has a {Glock1nizzle.ammoCap} ammo capacity");
            Console.WriteLine($"The {Mossbizzle590.name} fires a {Mossbizzle590.caliber} and has a {Mossbizzle590.ammoCap} ammo capacity");
            Console.WriteLine($"The {Mfizzle.name} fires a {Mfizzle.caliber} and has a {Mfizzle.ammoCap} ammo capacity");
            Console.WriteLine($"The {SupRizzle.name} fires a {SupRizzle.caliber} and has a {SupRizzle.ammoCap} ammo capacity");
            Console.WriteLine();
            Console.WriteLine("Vehicles");
            Console.WriteLine("______________________________________________________________________________________________________________");
            

            //Vehicle Display
            Console.WriteLine($"The {Apizzle.name} can hold {Apizzle.capacity} Pax and runs off of {Apizzle.fuelType}");
            Console.WriteLine($"The {Blackdizzle.name} can hold {Blackdizzle.capacity} Pax and runs off of {Blackdizzle.fuelType}");
            Console.WriteLine($"The {Mwizzle.name} can hold {Mwizzle.capacity} Pax and runs off of {Mwizzle.fuelType}");
            Console.WriteLine($"The {LMTvizzle.name} can hold {LMTvizzle.capacity} Pax and runs off of {LMTvizzle.fuelType}");
            Console.WriteLine();
            Console.WriteLine("Soldiers");
            Console.WriteLine("______________________________________________________________________________________________________________");
           

            //Soldier Display
            Console.WriteLine($"The {sWizzle.name} eats {sWizzle.fuelType} and says {sWizzle.says}");
            Console.WriteLine($"The {medizzle.name} eats {medizzle.fuelType} and says {medizzle.says}");
            Console.WriteLine($"The {firstSarizzle.name} eats {firstSarizzle.fuelType} and says {firstSarizzle.says}");
            Console.WriteLine($"The {Ssizzle.name} eats {Ssizzle.fuelType} and says {Ssizzle.says}");
          








        }


    }










}
 
