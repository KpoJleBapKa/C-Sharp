using System;
//Створити клас ПаркРозваг. Створити клас Відвідувач, додати в нього властивості типу bool: покатався на амереканських гірках,
//постріляв в тирі, сходив в кімнату страху, сходив в кімнату кривих дзеркал, з’їв попкорн, покатався на чортовому колесі.
//Створити наступні методи в класі ПаркРозваг: покататись на амереканських гірках, постріляти в тирі, сходити в кімнату страху,
//сходити в кімнату кривих дзеркал, з’їсти попкорну, покататись на чортовому колесі. Всі методи приймають екземпляр класу Відвідувач
//і проставляють значенням true відповідні властивості екземпляру класу. Створити комбіновані делегати, які будуть виконувати весь,
//або частину функціоналу. Реалізувати можливість виводу значень всіх властивостей на екрану вигляді: Назва Властивості -- Значення
namespace лб11
{
    class Program
    {
        public class ParkRecreation
        {
            public void RideRollerCoaster(Visitor visitor)
            {
                visitor.WentOnRollerCoaster = true;
            }

            public void ShootAtShootingRange(Visitor visitor)
            {
                visitor.ShotAtShootingRange = true;
            }

            public void GoToRoomOfFear(Visitor visitor)
            {
                visitor.WentToRoomOfFear = true;
            }

            public void GoToRoomOfCrookedMirrors(Visitor visitor)
            {
                visitor.WentToRoomOfCrookedMirrors = true;
            }

            public void EatPopcorn(Visitor visitor)
            {
                visitor.AtePopcorn = true;
            }

            public void RideFerrisWheel(Visitor visitor)
            {
                visitor.RodeFerrisWheel = true;
            }
        }

        public class Visitor
        {
            public bool WentOnRollerCoaster { get; set; }
            public bool ShotAtShootingRange { get; set; }
            public bool WentToRoomOfFear { get; set; }
            public bool WentToRoomOfCrookedMirrors { get; set; }
            public bool AtePopcorn { get; set; }
            public bool RodeFerrisWheel { get; set; }
        }

        Action<Visitor> allActivities = (visitor) =>
        {
            ParkRecreation park = new ParkRecreation();
            park.RideRollerCoaster(visitor);
            park.ShootAtShootingRange(visitor);
            park.GoToRoomOfFear(visitor);
            park.GoToRoomOfCrookedMirrors(visitor);
            park.EatPopcorn(visitor);
            park.RideFerrisWheel(visitor);
        };

        public void DisplayProperties(Visitor visitor)
        {
            Console.WriteLine("WentOnRollerCoaster: " + visitor.WentOnRollerCoaster);
            Console.WriteLine("ShotAtShootingRange: " + visitor.ShotAtShootingRange);
            Console.WriteLine("WentToRoomOfFear: " + visitor.WentToRoomOfFear);
            Console.WriteLine("WentToRoomOfCrookedMirrors: " + visitor.WentToRoomOfCrookedMirrors);
            Console.WriteLine("AtePopcorn: " + visitor.AtePopcorn);
            Console.WriteLine("RodeFerrisWheel: " + visitor.RodeFerrisWheel);
        }
    }
}
