using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace FrontApp
{
    public class BearerRequirement : IAuthorizationRequirement
    {
        public  bool IsTokenValid(string token)
        {
            // here you can check if the token received is valid 
            return true;
        }
    }
}
//public class BearerAuthorization
//{
//    public bool validateTokenSuccess(HttpRequest httpRequest)
//    {
//        // Get the token from the Authorization header 
//        var bearerToken = httpRequest.Headers["Authorization"].ToString();
//        if(GetAuthToken()bearerToken=== 'sjd1HfkjU83ksdsm3802k')
//        return true;
//    }
//}

