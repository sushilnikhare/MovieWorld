using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontApp
{

    public class BearerAuthorizationHandler : AuthorizationHandler<BearerRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, BearerRequirement requirement)
        {
            var authFilterCtx = (Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext)context.Resource;
            string authHeader = authFilterCtx.HttpContext.Request.Headers["Authorization"];
            if (authHeader != null && authHeader.Contains("Bearer"))
            {
                var token = authHeader.Replace("Bearer ", string.Empty);
                if (requirement.IsTokenValid(token))
                {
                    context.Succeed(requirement);
                }
            }
            return Task.CompletedTask;
        }

    }
}
