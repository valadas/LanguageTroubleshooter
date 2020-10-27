namespace Eraware.Modules.LanaguageTroubleshooter.Services
{
    using DotNetNuke.Web.Api;

    /// <summary>
    /// Implements the Dnn IServiceRouteMapper to register this module routes.
    /// </summary>
    public class ServiceRouteMapper : IServiceRouteMapper
    {
        /// <inheritdoc/>
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager?.MapHttpRoute("Eraware_LanaguageTroubleshooter", "default", "{controller}/{action}", new[] { typeof(ServiceRouteMapper).Namespace });
        }
    }
}