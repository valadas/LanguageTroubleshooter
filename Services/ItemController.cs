namespace Eraware.Modules.LanaguageTroubleshooter.Services
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Web.Http;
    using DotNetNuke.Security;
    using DotNetNuke.Web.Api;

    /// <summary>
    /// Provides Web API access for items.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "TODO: Implement localization.")]
    public class ItemController : ModuleApiController
    {
        /// <summary>
        /// Gets localization information.
        /// </summary>
        /// <returns>Various localization information.</returns>
        [HttpGet]
        [AllowAnonymous]
        public HttpResponseMessage GetCultureInfo()
        {
            try
            {
                string cookieLanguage = string.Empty;
                var cookie = this.Request.Headers.GetCookies("language").FirstOrDefault();
                if (cookie != null)
                {
                    cookieLanguage = cookie["language"].Value;
                }
                var languageInfo = new
                {
                    Thread.CurrentThread.CurrentCulture,
                    Thread.CurrentThread.CurrentUICulture,
                    this.UserInfo.Profile.PreferredLocale,
                    this.Request.RequestUri,
                    AppectLanguage = this.Request.Headers.Where(h => h.Key == "Accept-Language"),
                    cookieLanguage,
                    DnnCurrentLocale = DotNetNuke.Services.Localization.LocaleController.Instance.GetCurrentLocale(this.PortalSettings.PortalId).Code,
                    DnnDefaultLocale = DotNetNuke.Services.Localization.LocaleController.Instance.GetDefaultLocale(this.PortalSettings.PortalId).Code,
                };

                return this.Request.CreateResponse(HttpStatusCode.OK, languageInfo);
            }
            catch (Exception ex)
            {
                return this.Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
                throw;
            }
        }
    }
}