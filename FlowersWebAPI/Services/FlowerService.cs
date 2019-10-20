using DataAccess;
using DataModels;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class FlowerService: IFlowerService
    {
        private readonly IRepository<FlowerDto> _flowerRepository;
        public FlowerService(IRepository<FlowerDto> flowerRepository)
        {
            _flowerRepository = flowerRepository;
        }

        public IEnumerable<FlowerModel> GetFlowers()
        {

            return _flowerRepository.GetAll()
                    .Select(f => new FlowerModel()
                    {
                        Id = f.Id,
                        BloomTime = f.BloomTime,
                        Description = f.Description,
                        Humidity = f.Humidity,
                        Images = f.Images,
                        Name = f.Name,
                        LatinName = f.LatinName,
                        Price = f.Price,
                        TitleImage = f.TitleImage,
                        Light = f.Light,
                        Type = (FlowerType)Enum.Parse(typeof(FlowerType), f.Type, true)
                    });
        }

        public IEnumerable<FlowerModel> GetFlowersByType(FlowerType type)
        {
            return _flowerRepository.GetAll()
                   .Select(f => new FlowerModel()
                   {
                       Id = f.Id,
                       BloomTime = f.BloomTime,
                       Description = f.Description,
                       Humidity = f.Humidity,
                       Images = f.Images,
                       Name = f.Name,
                       LatinName = f.LatinName,
                       Price = f.Price,
                       TitleImage = f.TitleImage,
                       Light = f.Light,
                       Type = (FlowerType)Enum.Parse(typeof(FlowerType), f.Type, true)
                   })
                   .Where(x => x.Type == type);
        }
    }
}
