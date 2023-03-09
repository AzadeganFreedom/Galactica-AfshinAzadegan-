namespace Galactica_AfshinAzadegan_
{
    internal class SpaceObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public class Position
        {
            public double x { get; set; }
            public double y { get; set; }

            public override string ToString()
            {
                return "Position: (" + x + ", " + y + ")";
            }
        }
        
    }
}
