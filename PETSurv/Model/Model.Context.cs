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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PETSurvDBEntities : DbContext
    {
        public PETSurvDBEntities()
            : base("name=PETSurvDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agents> Agents { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<GroupMembers> GroupMembers { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Informants> Informants { get; set; }
        public virtual DbSet<Logins> Logins { get; set; }
        public virtual DbSet<Nationalities> Nationalities { get; set; }
        public virtual DbSet<Observants> Observants { get; set; }
        public virtual DbSet<OldReports> OldReports { get; set; }
        public virtual DbSet<PaymentMethods> PaymentMethods { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
    }
}
