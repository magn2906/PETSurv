//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PETSurv.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Informants
    {
        public int Id { get; set; }
        public Nullable<int> PersonsId { get; set; }
        public Nullable<int> PrefPaymentID { get; set; }
        public Nullable<int> LoginsId { get; set; }
    
        public virtual Logins Logins { get; set; }
        public virtual PaymentMethods PaymentMethods { get; set; }
        public virtual Persons Persons { get; set; }
    }
}
