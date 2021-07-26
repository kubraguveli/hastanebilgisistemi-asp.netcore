using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama1.Models
{
    public class Ilce
    {
        public int IlceId { get; set; }
        public string IlceAdi { get; set; }

        public int IlId { get; set; }
        public Il Il { get; set; }
    }
}
