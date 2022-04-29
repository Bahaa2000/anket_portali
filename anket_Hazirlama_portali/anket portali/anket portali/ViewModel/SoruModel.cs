using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace anket_portali.ViewModel
{
    public class SoruModel
    {
        public int SoruId { get; set; }
        public string Soru { get; set; }
        public int SoruKategoriId { get; set; }
        public int SoruAnketId { get; set; }
    }
}