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
    
    public partial class Consumo
    {
        public int Id { get; set; }
        public int IdApto { get; set; }
        public int IdCliente { get; set; }
        public int IdTempo { get; set; }
        public int IdServico { get; set; }
        public int IdProduto { get; set; }
        public int ValorConsumo { get; set; }
        public int Quantidade { get; set; }
    
        public virtual Apartamento Apartamento { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Servico Servico { get; set; }
        public virtual Tempo Tempo { get; set; }
    }
}
