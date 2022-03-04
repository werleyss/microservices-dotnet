using AutoMapper;
using GreekShooping.ProductAPI.Data.ValueObjects;
using GreekShooping.ProductAPI.Model;

namespace GreekShooping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductVO, Product>().ReverseMap();
            
                });
            return mappingConfig;
        }
    }
}
