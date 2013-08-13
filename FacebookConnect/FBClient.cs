using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Facebook;
using System.Net;
using System.Collections.Specialized;

namespace FacebookConnect
{
    public class FBClient 
    {
        private static FBClient m_instance = null;
        private FacebookClient m_client;
        private static string m_accessToken;
        private string m_userId;

        /// <summary>
        /// Option to set different user id such as event id that belongs to the user who authinticated
        /// </summary>
        public string UserID { get { return m_userId; } set { m_userId = value; } }
        public static string AccessToken { set { m_accessToken = value; } }

        public static FBClient Instance 
        {
            get 
            { 
                if (m_instance == null)
                    m_instance = new FBClient();

                return m_instance; 
            } 
        }


        private FBClient()
        {
            m_client = new FacebookClient(m_accessToken);
            //by default the user id will belong to the user who authinticated
            dynamic result = m_client.Get("me", new { fields = "id" });
            m_userId = result.id;
        }

        /// <summary>
        /// posting a messege to user feed
        /// </summary>
        /// <param name="messege"></param>
        public void post(string messege)
        {
            using (WebClient client = new WebClient())
            {
                string address = String.Format("https://graph.facebook.com/{0}/feed",m_userId);
                byte[] response = client.UploadValues(address, new NameValueCollection()
                   {
                       { "message", messege },
                       { "access_token", m_accessToken }
                   });
            }
        }

        /// <summary>
        /// Example of how we can get the user first and last name
        /// </summary>
        /// <returns></returns>
        public string getUserFacebookName()
        {
            dynamic result = m_client.Get("me", new { fields = "name" });
            return result.name;
        }
    }


}