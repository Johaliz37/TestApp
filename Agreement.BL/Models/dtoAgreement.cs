using System;
using System.Collections.Generic;
using System.Text;

namespace Agreement.Logic.Models
{
    public class dtoAgreement
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
