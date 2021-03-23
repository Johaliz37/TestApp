using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Agreement.Mobile.ViewModels
{
    internal class Agreement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
