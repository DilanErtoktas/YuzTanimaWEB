//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FaceNew.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class rapor
    {
        public short personel_ID { get; set; }
        public Nullable<System.DateTime> giris_saat { get; set; }
        public Nullable<System.DateTime> cıkıs_saat { get; set; }
        public Nullable<short> oda_ID { get; set; }
        public Nullable<short> birim_ID { get; set; }
    
        public virtual oda oda { get; set; }
        public virtual personel personel { get; set; }
        public virtual personel_birim personel_birim { get; set; }
    }
}
