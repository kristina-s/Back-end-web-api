using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class FlowerModel
    {
        public int Id { get; set; }
        public FlowerType Type { get; set; }
        public string Name { get; set; }
        public string LatinName { get; set; }
        public string TitleImage { get; set; }
        public string BloomTime { get; set; }
        public string Humidity { get; set; }
        public string Light { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public List<string> Images { get; set; } = new List<string>();
    }

    public enum FlowerType
    {
        Potted,
        Branch
    }
}
