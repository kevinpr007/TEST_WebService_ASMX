﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1_BORRAR
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Borrar_DBEntities : DbContext
    {
        public Borrar_DBEntities()
            : base("name=Borrar_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Table_22> Table_22 { get; set; }
        public virtual DbSet<Table_Borrar> Table_Borrar { get; set; }
    
        public virtual ObjectResult<My_Borrar_SP_Result> My_Borrar_SP(Nullable<int> p1)
        {
            var p1Parameter = p1.HasValue ?
                new ObjectParameter("p1", p1) :
                new ObjectParameter("p1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<My_Borrar_SP_Result>("My_Borrar_SP", p1Parameter);
        }
    
        public virtual ObjectResult<My_Borrar_SP1_Result> My_Borrar_SP1(string p1)
        {
            var p1Parameter = p1 != null ?
                new ObjectParameter("p1", p1) :
                new ObjectParameter("p1", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<My_Borrar_SP1_Result>("My_Borrar_SP1", p1Parameter);
        }
    }
}
