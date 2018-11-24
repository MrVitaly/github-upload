using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Experiment
{
  public partial class Form1 : Form
  {
    public ChromiumWebBrowser cromiumWebBrowser;
    public Form1()
    {
      InitializeComponent();
      InitializeCromium();
    }

    private void InitializeCromium()
    {
      CefSettings cefSettings = new CefSettings();
      Cef.Initialize(cefSettings);
      cromiumWebBrowser = new ChromiumWebBrowser("http://opensource.spotify.com/cefbuilds/index.html");
      this.Controls.Add(cromiumWebBrowser);
      cromiumWebBrowser.Dock = DockStyle.Fill;
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {

    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      Cef.Shutdown();
    }
  }
}
