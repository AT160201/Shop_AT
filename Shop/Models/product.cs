//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product()
        {
            this.OrderLines = new HashSet<OrderLine>();
        }
    
        public int id_pro { get; set; }
        public Nullable<int> id_cat { get; set; }
        public string name_pro { get; set; }
        public string images { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<double> price { get; set; }
        public string supplier { get; set; }
        public string infor { get; set; }
        public Nullable<int> sell_ID { get; set; }
    
        public virtual category category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
