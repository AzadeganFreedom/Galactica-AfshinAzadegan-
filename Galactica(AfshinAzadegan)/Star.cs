namespace Galactica_AfshinAzadegan_
{
    enum Startype { YellowDwarf = 1, White, BlueNeutron, RedGiant}
    internal class Star : SpaceObject
    {
        //string star = "Sun";

        //string planet1 = "Mercury";
        //string planet2 = "Venus";
        //string planet3 = "Earth";

        public Startype Type { get; set; }
        public double Temperature { get; set; }
        public PlanetType PlanetType { get; set; }
        public static List<Planet> PlanetList { get; set; }

        //public Planet() { }
        //public Planet(int id, string name, PlanetType planetType, Moon orbiting)
        //{
        //    Id = id;
        //    Name = name;
        //    PlanetType = planetType;
        //    Orbiting = orbiting;
            
        //}



    }
}
