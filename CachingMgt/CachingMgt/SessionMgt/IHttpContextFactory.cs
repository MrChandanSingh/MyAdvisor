namespace CachingMgt.SessionMgt
{
    using System.Web;
   public interface IHttpContextFactory
    {
        HttpSessionStateBase GetHttpSessionStateBase();
    }
}
