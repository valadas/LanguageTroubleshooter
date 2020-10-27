
namespace UnitTests.Common
{
    using System;
    using Xunit;
    using Eraware.Modules.LanaguageTroubleshooter.Common;

    public class GlobalsTests
    {
        [Fact]
        public void ModulePrefixIsValid()
        {
            var modulePrefix = Globals.ModulePrefix;
            Assert.Equal(expected: "Era_LanaguageTroubleshooter_", modulePrefix);
        }
    }
}
