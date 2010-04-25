using System;
using System.Web;

namespace TotalTech.CMS.Web {
    public class YUIHandler : IHttpHandler {
        /// <summary>
        /// You will need to configure this handler in the web.config file of your 
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public bool IsReusable {
            // Return false in case your Managed Handler cannot be reused for another request.
            // Usually this would be false in case you have some state information preserved per request.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context) {
            //write your handler implementation here.
            string Obj = context.Request["object"];
            if (!string.IsNullOrEmpty(Obj)) {
                switch (Obj.ToLower()) { 
                    case "dashboard":
                        Newtonsoft.Json.Linq.JObject ResultSet = new Newtonsoft.Json.Linq.JObject();
                        System.Xml.XmlDocument xDoc = new System.Xml.XmlDocument();
                        xDoc.Load(context.Server.MapPath("~/Admin/Config/ApplicationSettings.xml"));
                        Newtonsoft.Json.Converters.XmlNodeConverter converter = new Newtonsoft.Json.Converters.XmlNodeConverter();
                        string OutputJSON = Newtonsoft.Json.JsonConvert.SerializeXmlNode(xDoc).Replace("@", string.Empty);
                        context.Response.Write(OutputJSON);
                        break;
                }
            }
        }

        #endregion
    }
}
