//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Table_Borrar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_Borrar()
        {
            this.Table_22 = new HashSet<Table_22>();
        }
    
        public string MyColumn { get; set; }
        public long pk1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_22> Table_22 { get; set; }
    }
}
