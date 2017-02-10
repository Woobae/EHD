namespace Launcher
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainWeb = new System.Windows.Forms.WebBrowser();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCollaps = new System.Windows.Forms.Button();
            this.gameList = new System.Windows.Forms.ListView();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWeb
            // 
            this.mainWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWeb.Location = new System.Drawing.Point(0, 0);
            this.mainWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.mainWeb.Name = "mainWeb";
            this.mainWeb.Size = new System.Drawing.Size(984, 522);
            this.mainWeb.TabIndex = 0;
            this.mainWeb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.mainWeb_DocumentCompleted);
            this.mainWeb.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.mainWeb_Navigating);
            this.mainWeb.NewWindow += new System.ComponentModel.CancelEventHandler(this.mainWeb_NewWindow);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.button2);
            this.mainSplitContainer.Panel1.Controls.Add(this.button1);
            this.mainSplitContainer.Panel1.Controls.Add(this.btnCollaps);
            this.mainSplitContainer.Panel1.Controls.Add(this.mainWeb);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainSplitContainer.Panel2.BackgroundImage")));
            this.mainSplitContainer.Panel2.Controls.Add(this.gameList);
            this.mainSplitContainer.Size = new System.Drawing.Size(984, 611);
            this.mainSplitContainer.SplitterDistance = 522;
            this.mainSplitContainer.SplitterWidth = 1;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(879, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(798, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCollaps
            // 
            this.btnCollaps.Location = new System.Drawing.Point(0, 505);
            this.btnCollaps.Name = "btnCollaps";
            this.btnCollaps.Size = new System.Drawing.Size(70, 20);
            this.btnCollaps.TabIndex = 2;
            this.btnCollaps.Text = "Collapse";
            this.btnCollaps.UseVisualStyleBackColor = true;
            this.btnCollaps.Click += new System.EventHandler(this.btnCollaps_Click);
            // 
            // gameList
            // 
            this.gameList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameList.BackgroundImage")));
            this.gameList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameList.Location = new System.Drawing.Point(0, 0);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(984, 88);
            this.gameList.TabIndex = 0;
            this.gameList.UseCompatibleStateImageBehavior = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.mainSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser mainWeb;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Button btnCollaps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView gameList;
    }
}

