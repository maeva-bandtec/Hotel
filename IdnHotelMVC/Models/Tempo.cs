//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdnHotelMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tempo
    {
        public Tempo()
        {
            this.Consumo = new HashSet<Consumo>();
            this.Hospedagem = new HashSet<Hospedagem>();
        }
    
        public int Id { get; set; }
        public int Ano { get; set; }
        public int Trimestre { get; set; }
        public string Mes { get; set; }
    
        public virtual ICollection<Consumo> Consumo { get; set; }
        public virtual ICollection<Hospedagem> Hospedagem { get; set; }
    }
}