//using System.Runtime.Intrinsics.Arm.Arm64;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using APIDay10.Entities;
namespace APIDay10.DB {
    public class StudentContext : DbContext {
       public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        public DbSet<Student> Student {get; set;}
       
    }
}