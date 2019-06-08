using CachingMgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingMgt.SessionMgt
{
  public  interface IUserSession
    {
        void SetUserInfo(UserInfo userInfo);
        UserInfo GetUserInfo();
        
    }
}
