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
    public static FlowerDto ToFlowerDto(this Flower flower)
    {
        return new FlowerDto
        {
            Id = flower.Id,
            Name = flower.Name,
            Age = flower.Age,
            Color = flower.Color
        };
    }
}