﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace paths
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MajarraEntities : DbContext
    {
        public MajarraEntities()
            : base("name=MajarraEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<comments_data> comments_data { get; set; }
        public virtual DbSet<courses_data> courses_data { get; set; }
        public virtual DbSet<path_data> path_data { get; set; }
        public virtual DbSet<sub_path_data> sub_path_data { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<users_data> users_data { get; set; }
    }
}
