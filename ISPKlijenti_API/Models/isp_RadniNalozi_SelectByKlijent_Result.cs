//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISPKlijenti_API.Models
{
    using System;
    
    public partial class isp_RadniNalozi_SelectByKlijent_Result
    {
        public int Id { get; set; }
        public System.DateTime DatumKreiranja { get; set; }
        public string Klijent { get; set; }
        public string Usluga { get; set; }
        public string Dodijeljeno { get; set; }
        public string Detalji { get; set; }
        public string Adresa { get; set; }
        public string StatusNaloga { get; set; }
        public Nullable<double> IznosZaNaplatu { get; set; }
    }
}