using System;
using System.Collections.Generic;

namespace Agreement.DAL.Models
{
    public partial class Agreement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
