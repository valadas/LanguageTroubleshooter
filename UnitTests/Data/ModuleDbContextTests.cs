﻿using Eraware.Modules.LanaguageTroubleshooter.Data;
using Eraware.Modules.LanaguageTroubleshooter.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTests.Data
{
    public class ModuleDbContextTests
    {
        [Fact]
        public void DefaultConstructorThrows()
        {
            var context = new ModuleDbContext();
            Exception ex = Assert.Throws<InvalidOperationException>(() =>
            {
                context.Items.Add(new Item());
            });

            Assert.Equal("No connection string named 'SiteSqlServer' could be found in the application config file.", ex.Message);
        }
    }
}
