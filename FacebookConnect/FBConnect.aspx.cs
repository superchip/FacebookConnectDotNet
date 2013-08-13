using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Facebook;
using System.Threading;

namespace FacebookConnect
{
    public partial class FBConnect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //user posts on his wall (on behalf of the app)
                FBClient.AccessToken = Session["AccessToken"].ToString();
                FBClient.Instance.post("This post comes from .Net application");

                //example for post on wall event
                FBClient.Instance.UserID = "158836540967678";
                FBClient.Instance.post("This post comes from .Net application");

                div_userInfo.InnerText = "Published!";

            }

            catch (Exception ex)
            {
                div_userInfo.InnerText = ex.Message;
            }

        }
    }
}