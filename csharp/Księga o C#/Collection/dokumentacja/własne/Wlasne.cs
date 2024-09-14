using System;
using System.Collections.Generic;

namespace dokumentacja
{
    class Wlasne
    {
        public void IterateThroughList()
        {
            var theGalaxies = new List<Galaxy>
                {
                    new Galaxy() { Name="Tadpole", MegaLightYears=400},
                    new Galaxy() { Name="Pinwheel", MegaLightYears=25},
                    new Galaxy() { Name="Milky Way", MegaLightYears=0},
                    new Galaxy() { Name="Andromeda", MegaLightYears=3}
                };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);
            }
        }
    }
}