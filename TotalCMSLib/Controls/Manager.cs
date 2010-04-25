using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TotalTech.CMS.Controls {
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:Manager runat=server></{0}:Manager>")]
    public class Manager : WebControl {
        bool _requireLogin = false;
        public bool RequireLogin {
            get {
                return _requireLogin;
            }
            set {
                _requireLogin = value;
            }
        }

        protected override void OnInit(EventArgs e) {
            Page.InitComplete += new EventHandler(Page_InitComplete);
            base.OnInit(e);            
        }

        void Page_InitComplete(object sender, EventArgs e) {
            if (RequireLogin && !SiteSettings.ContextData.CurrentUser.IsLoggedIn) {
                throw new Exception("The current user is not logged in.");
            }
        }



        protected override void RenderContents(HtmlTextWriter output) {
            
        }
    }
}
