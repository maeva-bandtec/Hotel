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
    
    public partial class Hospedagem
    {
        public int Id { get; set; }
        public int IdApto { get; set; }
        public int IdAgencia { get; set; }
        public int IdCliente { get; set; }
        public int IdTempo { get; set; }
        public int ValorFaturado { get; set; }
    
        public virtual Agencia Agencia { get; set; }
        public virtual Apartamento Apartamento { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Tempo Tempo { get; set; }
    }
}
