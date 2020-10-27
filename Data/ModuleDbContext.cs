﻿namespace Eraware.Modules.LanaguageTroubleshooter.Data
{
    using System.Data.Common;
    using System.Data.Entity;
    using Eraware.Modules.LanaguageTroubleshooter.Data.Entities;

    /// <summary>
    /// The data context for this module.
    /// </summary>
    public class ModuleDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleDbContext"/> class.
        /// </summary>
        public ModuleDbContext()
            : base("name=SiteSqlServer")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleDbContext"/> class.
        /// </summary>
        /// <param name="connection">An existing <see cref="DbConnection"/>.</param>
        public ModuleDbContext(DbConnection connection)
            : base(connection, true)
        {
        }

        /// <summary>
        /// Gets or sets the module items.
        /// </summary>
        public DbSet<Item> Items { get; set; }
    }
}