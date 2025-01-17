namespace Carter.Tests.Security
{
    using Microsoft.AspNetCore.Http;

    public class SecureSinglePolicyModule : CarterModule
    {
        public SecureSinglePolicyModule()
        {
            this.RequiresPolicy("reallysecurepolicy");

            this.Get("/securepolicy", async (request, response, routeData) => { await response.WriteAsync("secure"); });
        }
    }
}
