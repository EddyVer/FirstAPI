using MakeAPI.Entities;
using MakeAPI.Extention;

namespace MakeAPI.Context
{
    public class FleuristeContext
    {

        public List<Fleuriste> Fleuristes { get; set;}
        public List<FleuristeDto> FleuristeDtos { get; set;}

        public List<Fleuriste> List() => Fleuristes;

        public void FleuristeAdd(Fleuriste fleuriste) 
        {
            fleuriste.Id = Fleuristes.Count;
            Fleuristes.Add(fleuriste);
        }

        public void FleuristeModif(int id, Fleuriste fleuriste)
        {
            var mFleuriste = Fleuristes.First(x => x.Id == id);
            mFleuriste.Name = fleuriste.Name;
            mFleuriste.NumbEmplois = fleuriste.NumbEmplois;
            mFleuriste.Longitude = fleuriste.Longitude;
            mFleuriste.Latidude = fleuriste.Latidude;
            mFleuriste.Adresse = fleuriste.Adresse;
            mFleuriste.Flowers = fleuriste.Flowers;
        }
        public FleuristeContext()
        {
            Fleuristes = new List<Fleuriste>();
            Fleuristes.Add(new Fleuriste()
            {
                Id = 1,
                Name = "A Fleurs de Peau",
                NumbEmplois = 2,
                Latidude = -5.05055,
                Longitude = 95.50689,
                Adresse = "Quelque par dans l'ocean Indien N° 1",
                Flowers = new List<Flower>() {
                     new Flower{
                        Id = 1,
                        Name = "tulipe",
                        Age = 5,
                        Color = new Color()
                        {
                            Id = 1,
                            Name = "blanc"
                        }
                      },
                     new Flower
                     {                                    
                         Id = 2,
                         Name = "orchidée",
                         Age = 2,
                         Color = new Color()
                         {
                             Id = 2,
                             Name = "Rose"
                         }
                     }
                }
            });
            Fleuristes.Add(new Fleuriste() { 
                Id = 2,
                Name ="Mon ChouFleurs",
                NumbEmplois = 10,
                Latidude = 37.97792,
                Longitude = 77.77584,
                Adresse = "En Chine a l'ouest",
                Flowers= new List<Flower>() { 
                    new Flower(){
                        Id = 1,
                        Name = "ronse",
                        Age= 3,
                        Color = new Color()
                        {
                            Id = 1,
                            Name = "vert"
                        }
                    },
                    new Flower()
                    {
                        Id= 2,
                        Name = "fougerre",
                        Age = 8,
                        Color = new Color
                        {
                            Id = 2,
                            Name = "purple"
                        }
                    }
                }
            });

        }
    }
}
