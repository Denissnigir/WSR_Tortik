﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSR_Tort.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WSR_TortikEntities : DbContext
    {
        public WSR_TortikEntities()
            : base("name=WSR_TortikEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CakeDecoration> CakeDecoration { get; set; }
        public virtual DbSet<CakeDecorationType> CakeDecorationType { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentType> EquipmentType { get; set; }
        public virtual DbSet<Gost> Gost { get; set; }
        public virtual DbSet<Ingridient> Ingridient { get; set; }
        public virtual DbSet<IngridientType> IngridientType { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SpecificationCakeDecoration> SpecificationCakeDecoration { get; set; }
        public virtual DbSet<SpecificationIngridient> SpecificationIngridient { get; set; }
        public virtual DbSet<SpecificationOperation> SpecificationOperation { get; set; }
        public virtual DbSet<SpecificationSemiProduct> SpecificationSemiProduct { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}