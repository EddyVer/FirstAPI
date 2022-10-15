using MakeAPI.Context;

namespace MakeAPI.Entities
{
    public class Fleuriste
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumbEmplois { get; set; }
        public double Latidude { get; set; }
        public double Longitude { get; set; }
        public string Adresse { get; set; }
        public List<Flower> Flowers { get; set; }
        
    }
}
