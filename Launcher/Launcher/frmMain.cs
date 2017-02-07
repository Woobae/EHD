using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Launcher
{
    public partial class frmMain : Form
    {
        private string StartGameHeader = "NToGame://";
        private bool SplitPanel2Collapsed = false;

        public frmMain()
        {
            InitializeComponent();
            mainWeb.Navigate("http://www.naver.com");

            //mainWeb.Navigating += new WebBrowserNavigatingEventHandler(mainWeb_Navigating);
        }

        private void mainWeb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void mainWeb_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.ToString().StartsWith(StartGameHeader))
            {
                e.Cancel = true;
                StartGame(e.Url.ToString().Replace(StartGameHeader, ""));
            }
        }

        private void StartGame(string gmaeUrl)
        {
        }

        private void btnCollaps_Click(object sender, EventArgs e)
        {
            SplitPanel2Collapsed = !SplitPanel2Collapsed;
            mainSplitContainer.Panel2Collapsed = SplitPanel2Collapsed;
            if (SplitPanel2Collapsed)
            {
                btnCollaps.Location = new Point(0, 595);
                btnCollaps.Text = "Show";
            }
            else
            {
                btnCollaps.Location = new Point(0, 505);
                btnCollaps.Text = "Hide";
            }
        }

        private void mainWeb_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void ResizeMe(int Width, int Height, int targetWidth, int targetHeight)
        {
            //int diffWidth = Math.Abs(Width - targetWidth);
            //int diffHeight = Math.Abs(Height - targetHeight);
            //int loopCount = diffWidth > diffHeight ? diffWidth : diffHeight;

            //while (loopCount > 0)
            //{
            //    loopCount--;

            //    if (Width > targetWidth) Width = Width - 5;
            //    if (targetWidth > Width) Width = Width + 5;

            //    if (Height > targetHeight) Height = Height - 5;
            //    if (targetHeight > Height) Height = Height + 5;

            //    this.Width = Width;
            //    this.Height = Height;

            //    //MoveToCenter();
            //    //Application.DoEvents();
            //}

            this.Width = targetWidth;
            this.Height = targetHeight;

            MoveToCenter();
            Application.DoEvents();
        }

        private void MoveToCenter()
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResizeMe(this.Width, this.Height, 1500, 1000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResizeMe(this.Width, this.Height, 1000, 650);
        }
    }
}
