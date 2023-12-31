//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EdithTour.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Airline
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Airline()
        {
            this.Combo = new HashSet<Combo>();
        }
    
        public int ID_airline { get; set; }
        public string Name { get; set; }
        public string Air_Code { get; set; }
        public string Place_go { get; set; }
        public string Place_leave { get; set; }
        public string Time_go { get; set; }
        public string Time_leave { get; set; }
        public string Day_go { get; set; }
        public string Day_leave { get; set; }
        public string Note { get; set; }
        public string Ticket { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Note_ticket { get; set; }
        public Nullable<int> ID_service { get; set; }
    
        public virtual Service Service { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Combo> Combo { get; set; }
    }
}
