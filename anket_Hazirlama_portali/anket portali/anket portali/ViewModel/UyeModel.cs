using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace anket_portali.ViewModel
{
    public class UyeModel
    {
        public int UyeId { get; set; }
        public string KullaniciAdi { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public bool Admin { get; set; }
        public int UyeCevapId { get; set; }
        public int UyeSoruId { get; set; }
    }
}