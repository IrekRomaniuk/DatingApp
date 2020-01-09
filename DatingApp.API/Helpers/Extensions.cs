using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
       public static void AddAppplicationError(this HttpResponse response , string message) {
           response.Headers.Add("Application-Error", message);
           response.Headers.Add("Access-Controllers-Expose-Headers","Application-Error");
           response.Headers.Add("Access-Control-Allow-Origin","*");
       } 
    }
}