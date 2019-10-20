using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IFlowerService
    {
        IEnumerable<FlowerModel> GetFlowers();
        IEnumerable<FlowerModel> GetFlowersByType(FlowerType type);
    }
}
