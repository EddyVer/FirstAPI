namespace MakeAPI.Context
{
    using Entities;
    using MakeAPI.Dtos;

    public class FlowersContext
    { 
        
        // public List<Color> Colors {set; get;}
        
        public List<Flower> Flowers { get; set;}
        public List<FlowerDto> FlowersDtos {set; get;}
       public List<Flower> List() => Flowers;
       public Flower GetId(int id) => Flowers.First(x => x.Id == id);
       public Flower GetName(string name) => Flowers.First(x => x.Name == name);
       public Flower GetColor(string color) => Flowers.First(x => x.Color.Name == color);


       public void FlowerAdd(Flower flower)
       {
            flower.Id = Flowers.Count+1;
            Flowers.Add(flower);
       }

       public void FlowerModif(int id, Flower flower)
       {
           var mFlower =  Flowers.First(x => x.Id == id);
           mFlower.Name = flower.Name;
           mFlower.Age = flower.Age;
           mFlower.Color.Name = flower.Color.Name;
           
       }

       public void DeleteFlower(int id)
       {
           Flowers.Remove(GetId(id));
       }
        
       public FlowersContext()
        {
            Flowers = new List<Flower>();
            Flowers.Add(new Flower()
            {
                Id = 1,
                Name = "tulipe",
                Age = 5,
                Color = new Color()
                {
                        Id = 1,
                        Name = "blanc"
                }
            });
            Flowers.Add(new Flower()
            {
                Id = 2,
                Name = "orchidée",
                Age = 2,
                Color = new Color()
                {
                    Id = 2,
                    Name = "Rose"
                }
            });

        }
        
    }
}