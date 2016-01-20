﻿namespace System.Web
{
    using System.Web;
    using Microsoft.ApplicationInsights.DataContracts;
    using Microsoft.ApplicationInsights.Web.Implementation;

    /// <summary>
    /// HttpContextExtension class provides extensions methods for accessing Web Application Insights objects.
    /// </summary>
    public static class HttpContextExtension
    {
        /// <summary>
        /// Provide access to request generated by Web Application Insights SDK.
        /// </summary>
        /// <param name="context">HttpContext instance.</param>
        /// <returns>Request telemetry instance or null.</returns>
        public static RequestTelemetry GetRequestTelemetry(this HttpContext context)
        {
            if (context == null)
            {
                return null;
            }

            return context.Items[RequestTrackingConstants.RequestTelemetryItemName] as RequestTelemetry;
        }
    }
}