//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace anket_portali.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TUye
    {
        public int UyeId { get; set; }
        public string KullaniciAdi { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }
        public bool Admin { get; set; }
        public int UyeCevapId { get; set; }
        public int UyeSoruId { get; set; }
    
        public virtual TCevap TCevap { get; set; }
        public virtual TSoru TSoru { get; set; }
    }
}