﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WedApiAspForPostirushki.Models.Dto
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbStirkaEntities : DbContext
    {
        public dbStirkaEntities()
            : base("name=dbStirkaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Drying> Drying { get; set; }
        public virtual DbSet<Powder> Powder { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<StatusOfWash> StatusOfWash { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Wash> Wash { get; set; }
        public virtual DbSet<WashMachine> WashMachine { get; set; }
    }
}