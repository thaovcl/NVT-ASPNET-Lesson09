﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NVTLesson09.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NVT_K22CNT1Lesson07Entities1 : DbContext
    {
        public NVT_K22CNT1Lesson07Entities1()
            : base("name=NVT_K22CNT1Lesson07Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<nvtKhoa> nvtKhoas { get; set; }
        public virtual DbSet<nvtSV> nvtSVs { get; set; }
    }
}