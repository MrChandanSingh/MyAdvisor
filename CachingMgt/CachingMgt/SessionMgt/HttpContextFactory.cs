
namespace CachingMgt.SessionMgt
{
    using System.Web;
    public class HttpContextFactory : IHttpContextFactory
    {
        public HttpSessionStateBase GetHttpSessionStateBase()
        {
            HttpSessionStateBase sessionStateBase = new HttpSessionStateWrapper(HttpContext.Current.Session);
            return sessionStateBase;
        }
    }
}