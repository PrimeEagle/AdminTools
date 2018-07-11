using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Diagnostics;

namespace AdminUtils
{
	/// <summary>
	/// Summary description for Uptime.
	/// </summary>
	public class Uptime : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		System.Diagnostics.Process p = new System.Diagnostics.Process();
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			p.StartInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe","/c uptime.exe > C:\\Inetpub\\wwwroot\\AdminUtils\\uptime.html");
			p.Start();
			p.WaitForExit();
			Response.Redirect("uptime.html");
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			p.StartInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe","/c uptime.exe /s > C:\\Inetpub\\wwwroot\\AdminUtils\\uptime.html");
			p.Start();
			p.WaitForExit();
			Response.Redirect("uptime.html");
		}
	}
}
