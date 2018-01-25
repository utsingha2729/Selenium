namespace TestingProject
{
    partial class Form1
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
            this.btnChromeStart = new System.Windows.Forms.Button();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChromeStart
            // 
            this.btnChromeStart.Location = new System.Drawing.Point(38, 117);
            this.btnChromeStart.Name = "btnChromeStart";
            this.btnChromeStart.Size = new System.Drawing.Size(75, 23);
            this.btnChromeStart.TabIndex = 0;
            this.btnChromeStart.Text = "Start Chrome";
            this.btnChromeStart.UseVisualStyleBackColor = true;
            this.btnChromeStart.Click += new System.EventHandler(this.BtnChromeStart_Click);
            // 
            // btnNavigate
            // 
            this.btnNavigate.Location = new System.Drawing.Point(38, 191);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(75, 23);
            this.btnNavigate.TabIndex = 1;
            this.btnNavigate.Text = "Navigate";
            this.btnNavigate.UseVisualStyleBackColor = true;
            this.btnNavigate.Click += new System.EventHandler(this.BtnNavigate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(134, 191);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(134, 117);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(228, 191);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(75, 23);
            this.btnBackward.TabIndex = 5;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.BtnBackward_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(228, 117);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 4;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(393, 117);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(166, 20);
            this.txtUrl.TabIndex = 6;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Location = new System.Drawing.Point(319, 191);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(75, 23);
            this.btnMaximize.TabIndex = 7;
            this.btnMaximize.Text = "Maximized";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.Location = new System.Drawing.Point(413, 191);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(75, 23);
            this.btnMinimise.TabIndex = 8;
            this.btnMinimise.Text = "Minimise";
            this.btnMinimise.UseVisualStyleBackColor = true;
            this.btnMinimise.Click += new System.EventHandler(this.BtnMinimise_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(510, 191);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Seacrh";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 465);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNavigate);
            this.Controls.Add(this.btnChromeStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChromeStart;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimise;
        private System.Windows.Forms.Button btnSearch;
    }
}

