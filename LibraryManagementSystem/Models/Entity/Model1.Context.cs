﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_LIBRARYEntities : DbContext
    {
        public DB_LIBRARYEntities()
            : base("name=DB_LIBRARYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACTION_TABLE> ACTION_TABLE { get; set; }
        public virtual DbSet<AUTHOR_TABLE> AUTHOR_TABLE { get; set; }
        public virtual DbSet<BOOK_TABLE> BOOK_TABLE { get; set; }
        public virtual DbSet<CASHBOX_TABLE> CASHBOX_TABLE { get; set; }
        public virtual DbSet<CATEGORY_TABLE> CATEGORY_TABLE { get; set; }
        public virtual DbSet<EMPLOYEE_TABLE> EMPLOYEE_TABLE { get; set; }
        public virtual DbSet<MEMBER_TABLE> MEMBER_TABLE { get; set; }
        public virtual DbSet<PENALTY_TABLE> PENALTY_TABLE { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<CONTACT_TABLE> CONTACT_TABLE { get; set; }
        public virtual DbSet<MESSAGE_TABLE> MESSAGE_TABLE { get; set; }
    }
}
