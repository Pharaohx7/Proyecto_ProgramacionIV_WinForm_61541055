﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_AgenciaDigitalEntities : DbContext
    {
        public DB_AgenciaDigitalEntities()
            : base("name=DB_AgenciaDigitalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TB_Gestiones> TB_Gestiones { get; set; }
        public virtual DbSet<TB_Producto> TB_Producto { get; set; }
        public virtual DbSet<TB_Transacciones> TB_Transacciones { get; set; }
        public virtual DbSet<TB_Usuario> TB_Usuario { get; set; }
    }
}
