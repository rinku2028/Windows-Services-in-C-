using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Windows_Service
{
    public partial class Windowsservice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static void StartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                
            }
            catch
            {
                // ...
            }
        }
        protected void btnstart_Click(object sender, EventArgs e)
        {
            string ss = "iis";
            StartService(ss,10);
            lblmessage.Text = "service start";

        }
    }
}