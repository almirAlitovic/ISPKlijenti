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
    
    public partial class isp_PosebniRacuni_SelectAll_Result
    {
        public int Id { get; set; }
        public string Klijent { get; set; }
        public string Usluga { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal IznosBezPDV { get; set; }
        public decimal IznosSaPDV { get; set; }
        public System.DateTime VrijemeIsporuke { get; set; }
        public bool Placeno { get; set; }
        public string NacinPlacanja { get; set; }
    }
}
