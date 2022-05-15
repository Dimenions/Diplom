using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SSU.Coins.dbContext
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string MiddleName { get; set; }

        [MaxLength(100)]
        public string Login { get; set; }

        public byte[] HashPassword { get; set; }

        [MaxLength(10)]
        public int RoleWebSite { get; set; }

        public byte[] Avatar { get; set; }
    }
}

