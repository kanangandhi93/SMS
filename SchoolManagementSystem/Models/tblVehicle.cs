//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblVehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblVehicle()
        {
            this.tblVehiclePrevillages = new HashSet<tblVehiclePrevillage>();
        }
    
        public long VehicleId { get; set; }
        public string VehicleName { get; set; }
        public string VehicleNo { get; set; }
        public Nullable<long> VehicleTypeId { get; set; }
        public Nullable<int> BrId { get; set; }
        public Nullable<long> SchoolId { get; set; }
        public string Route { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblVehiclePrevillage> tblVehiclePrevillages { get; set; }
    }
}
