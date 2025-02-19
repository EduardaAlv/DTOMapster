using Mapster;
using MapsterDTOs.DTOs;
using MapsterDTOs.Models;

public static class MapsterConfig
{
    public static void Configure()
    {
        // Configure Product to ProductDto mapping
        TypeAdapterConfig<User, UserViewModel>.NewConfig()
            .Map(dest => dest.Name, src => src.Name)

            .Map(dest => dest.Adress, src => src.Adress);
        // Any other mappings
    }
}