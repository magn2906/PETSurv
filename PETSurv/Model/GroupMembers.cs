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
    
    public partial class GroupMembers
    {
        public int Id { get; set; }
        public int GroupsId { get; set; }
        public int ObservantsId { get; set; }
    
        public virtual Groups Groups { get; set; }
        public virtual Observants Observants { get; set; }
    }
}
