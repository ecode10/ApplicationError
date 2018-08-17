using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationError
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Exception caughtException = (Exception)Application["TheException"];
                Response.Write(caughtException.InnerException.ToString() + "<br>" + caughtException.Message.ToString() + "<br>" + caughtException.Source.ToString() + "<br>" + caughtException.StackTrace.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}