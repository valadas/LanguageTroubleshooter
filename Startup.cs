namespace Eraware.Modules.LanaguageTroubleshooter
{
    using DotNetNuke.DependencyInjection;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Implements the IDnnStartup interface to run at application start.
    /// </summary>
    public class Startup : IDnnStartup
    {
        /// <summary>
        /// Registers the dependencies for injection.
        /// </summary>
        /// <param name="services">The services collection.</param>
        public void ConfigureServices(IServiceCollection services)
        {
        }
    }
}