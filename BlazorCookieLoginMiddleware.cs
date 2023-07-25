using BrapShop.Data.models;
using BrapShop.Data.models.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Collections.Concurrent;

namespace BrapShop
{

    public class BlazorCookieLoginMiddleware
    {
        public static IDictionary<Guid, RegisterUser> Logins { get; private set; }
            = new ConcurrentDictionary<Guid, RegisterUser>();


        private readonly RequestDelegate _next;

        public BlazorCookieLoginMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, SignInManager<ApplicationUser> signInMgr)
        {
            if (context.Request.Path == "/login" && context.Request.Query.ContainsKey("key"))
            {
                var key = Guid.Parse(context.Request.Query["key"]);
                var info = Logins[key];

                var result = await signInMgr.PasswordSignInAsync(info.Email, info.Password, false, lockoutOnFailure: true);
                info.Password = null;
                if (result.Succeeded)
                {
                    Logins.Remove(key);
                    context.Response.Redirect("/");
                    return;
                }
                
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
