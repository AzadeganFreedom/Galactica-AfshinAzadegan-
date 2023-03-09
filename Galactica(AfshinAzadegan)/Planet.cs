using System.Numerics;

namespace Galactica_AfshinAzadegan_
{
    enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant}
    internal class Planet : SpaceObject
    {
        public PlanetType Type { get; set; }
        public double Diameter { get; set; } //in meters
        public double RotationPeriod { get; set; } //in hours
        public double RevolutionPeriod { get; set; } //in days

        public List<Moon> MoonList { get; set; }


        public void Distance()
        {
            double distance = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2));
        }

    }
}
