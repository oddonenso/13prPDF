﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pr_3.models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PhotooStudiiioooEntities2 : DbContext
    {
        public PhotooStudiiioooEntities2()
            : base("name=PhotooStudiiioooEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<contract> contract { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<oborudivanie> oborudivanie { get; set; }
        public virtual DbSet<product> product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<suppliers> suppliers { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
