using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels
{
    public class FlowerDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string LatinName { get; set; }
        public string TitleImage { get; set; }
        public string BloomTime { get; set; }
        public string Humidity { get; set; }
        public string Light { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        [NotMapped]
        public List<string> Images { get; set; }
    }
}
