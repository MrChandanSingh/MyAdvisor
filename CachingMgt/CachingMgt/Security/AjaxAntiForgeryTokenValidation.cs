using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace CachingMgt.Security
{
    public class AjaxAntiForgeryTokenValidation : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                this.ValidateRequestHeader(filterContext.HttpContext.Request);
            }
            else
            {
                AntiForgery.Validate();
            }
        }

        private void ValidateRequestHeader(HttpRequestBase request)
        {
            string formToken = string.Empty;
            string cookieToken = string.Empty;
            try
            {
                string tokenValue = request.Headers["VerficationToken"];
                if (!string.IsNullOrEmpty(tokenValue))
                {
                    var token = tokenValue.Split(',');
                    if (token.Length == 2)
                    {
                        cookieToken = token[0].Trim();
                        formToken = token[1].Trim();
                    }

                }
            }
            catch (Exception ex)
            {
                throw;
            }

            AntiForgery
                .Validate(cookieToken, formToken);
        }
    }
}