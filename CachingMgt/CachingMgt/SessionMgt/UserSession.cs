using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CachingMgt.Models;
using CachingMgt.Utility;

namespace CachingMgt.SessionMgt
{
    public class UserSession : IUserSession
    {
        private const string UserInfoKey = "userInfo";
        private HttpSessionStateBase HttpSessionStateBase { get; set; }
        public UserSession(IHttpContextFactory httpContextFactory)
        {
            HttpSessionStateBase = httpContextFactory.GetHttpSessionStateBase();
        }

        /// <summary>
        /// Get User session data based on key.
        /// </summary>
        /// <returns></returns>
        public UserInfo GetUserInfo()
        {
         return HttpSessionStateBase.GetSessionData<UserInfo>(UserInfoKey);
        }

        /// <summary>
        /// Set user information into session with specified key.
        /// </summary>
        /// <param name="userInfo"></param>
        public void SetUserInfo(UserInfo userInfo)
        {
            HttpSessionStateBase.SetSessionData<UserInfo>(UserInfoKey,userInfo);
        }
    }
}