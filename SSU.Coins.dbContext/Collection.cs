using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.Coins.dbContext
{
    public class Collection
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int[] CoinId { get; set; }

        [MaxLength(20)]
        public double SaleCoin { get; set; }

        [MaxLength(1000000)]
        public string Information{ get; set; }

        public byte[] Picture { get; set; }
    }
}
