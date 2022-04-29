using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace anket_portali.ViewModel
{
    public class CevapModel
    {
        public int CevapId { get; set; }
        public string Cevap { get; set; }
        public int CevapSoruId { get; set; }
    }
}