using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SSU.Coins.dbContext
{
    public class RoleWebSite
    {
        public int Id { get; set; }

        [MaxLength(1000)]
        [Required]
        public string Name { get; set; }

    }
}
