using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAppTest.Shared
{
    public class Catastral
    {
        public string Sector { get; set; } = "0";
        public string Manzana { get; set; } = "0";
        public string Predio { get; set; } = "0";
        public string Division { get; set; } = "0";
        public string PVertical { get; set; } = "0";
        public string PHorizontal { get; set; } = "0";

        public override string ToString()
        {
            return $"{Sector}-{Manzana}-{Predio}-{Division}-{PVertical}-{PHorizontal}";
        }
    }
}
