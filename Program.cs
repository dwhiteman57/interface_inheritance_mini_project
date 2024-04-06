using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm s = new Storm("wind", false, "Harry");
            s.Announce();

            Pupil p = new Pupil("Ezra");
            Storm storm = p.CastWindStorm();
            storm.Announce();

            Mage m = new Mage("Ron");
            Storm rainStorm = m.CastRainStorm();
            rainStorm.Announce();

            Archmage am = new Archmage("Dumbledore");
            Storm amRainStorm = am.CastRainStorm();
            Storm lightningStorm = am.CastLightningStorm();
            amRainStorm.Announce();
            lightningStorm.Announce();
        }
    }
}