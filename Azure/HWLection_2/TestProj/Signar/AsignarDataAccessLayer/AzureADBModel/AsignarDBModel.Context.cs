﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsignarDataAccessLayer.AzureADBModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AsignarDBEntities : DbContext
    {
        public AsignarDBEntities()
            : base("name=AsignarDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Bug> Bugs { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Filter> Filters { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersToProject> UsersToProjects { get; set; }
    }
}
