using MakeAPI.Dtos;
using MakeAPI.Entities;

namespace MakeAPI.Extention;

public static class FlowerDtoMapping
{
    public static Flower ToFlower(this FlowerDto flowerDto)
    {
        return new Flower
        {
            Id = flowerDto.Id,
            Name = flowerDto.Name,
            Age = flowerDto.Age,
            Color = flowerDto.Color
        };
    }
}