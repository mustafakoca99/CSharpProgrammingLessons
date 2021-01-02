using System;
using System.Collections.Generic;
using System.Data.Entity;
//using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using CrudExpertCoder.Properties;
using System.ComponentModel.DataAnnotations;

namespace CrudExpertCoder
{
    public class modelcontext:DbContext
    {
        public modelcontext() : base("name=cn") { }
        public DbSet<student> studentlist { get; set; }
    }
}
