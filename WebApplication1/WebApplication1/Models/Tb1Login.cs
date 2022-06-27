using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Tb1Login
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? IsAdmin { get; set; }
    }
}
