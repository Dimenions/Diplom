using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.dbContext
{
    public class Coin
    {
        public int Id { get; set; }

        [MaxLength(1000)]
        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [MaxLength(100)]
        public int? Price { get; set; }

        //TODO
        //public string Anniversary { get; set; } юбилейная

        [MaxLength(10000)]
        public string Description { get; set; }


        public int IdCountry { get; set; }

        public int IdMaterial { get; set; }

        public byte[] Picture { get; set; }
    }
}
