using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FILE_UPLOAD.Models;
using Microsoft.EntityFrameworkCore;

namespace FILE_UPLOAD.ApplicationContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        

        public DbSet<FileOnDatabaseModel> FileOnDataBaseModels { get; set; }
        public DbSet<FileOnFileSystemModel> FileOnFileSysteModels { get; set; }

    }
}