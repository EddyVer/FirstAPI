using MakeAPI.Entities;

namespace MakeAPI.Extention
{
    public static class FleuristeDtoMapping
    {
        public static Fleuriste ToFleuriste(this FleuristeDto fleuristeDto)
        {
            return new Fleuriste
            {
                Id = fleuristeDto.Id,
                Name = fleuristeDto.Name,
                NumbEmplois = fleuristeDto.NumbEmplois,
                Latidude = fleuristeDto.Latidude,
                Longitude = fleuristeDto.Longitude,
                Adresse = fleuristeDto.Adresse,
                Flowers = fleuristeDto.Flowers
            };
        }
        public static FleuristeDto ToFleuristeDto(this Fleuriste fleuriste)
        {
            return new FleuristeDto
            {
                Id = fleuriste.Id,
                Name = fleuriste.Name,
                NumbEmplois = fleuriste.NumbEmplois,
                Latidude = fleuriste.Latidude,
                Longitude = fleuriste.Longitude,
                Adresse = fleuriste.Adresse,
                Flowers = fleuriste.Flowers
            };
        }
    }
}
