using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacebookConnect
{
    /// <summary>
    /// Summary description for FacebookLogin
    /// </summary>
    public class FacebookLogin : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            var accessToken = context.Request["accessToken"];
            context.Session["AccessToken"] = accessToken;

            context.Response.Redirect("FBConnect.aspx");
        }

        public bool IsReusable
        {
            get { return false; }
        }
    }
}