namespace Massenger
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            this.m_IpBoxClient1 = new System.Windows.Forms.TextBox();
            this.m_PortBoxClient1 = new System.Windows.Forms.TextBox();
            this.m_IPLabel = new System.Windows.Forms.Label();
            this.m_Port = new System.Windows.Forms.Label();
            this.m_IPEnter = new System.Windows.Forms.Button();
            this.m_Connect = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fdasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Group1 = new System.Windows.Forms.GroupBox();
            this.m_Group2 = new System.Windows.Forms.GroupBox();
            this.m_IP2 = new System.Windows.Forms.Label();
            this.m_IpBoxClient2 = new System.Windows.Forms.TextBox();
            this.m_Port2 = new System.Windows.Forms.Label();
            this.m_PortBoxClient2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.m_Group1.SuspendLayout();
            this.m_Group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_IpBoxClient1
            // 
            this.m_IpBoxClient1.Location = new System.Drawing.Point(58, 21);
            this.m_IpBoxClient1.Name = "m_IpBoxClient1";
            this.m_IpBoxClient1.Size = new System.Drawing.Size(126, 22);
            this.m_IpBoxClient1.TabIndex = 0;
            // 
            // m_PortBoxClient1
            // 
            this.m_PortBoxClient1.Location = new System.Drawing.Point(58, 62);
            this.m_PortBoxClient1.Name = "m_PortBoxClient1";
            this.m_PortBoxClient1.Size = new System.Drawing.Size(126, 22);
            this.m_PortBoxClient1.TabIndex = 1;
            // 
            // m_IPLabel
            // 
            this.m_IPLabel.AutoSize = true;
            this.m_IPLabel.Location = new System.Drawing.Point(6, 26);
            this.m_IPLabel.Name = "m_IPLabel";
            this.m_IPLabel.Size = new System.Drawing.Size(32, 17);
            this.m_IPLabel.TabIndex = 2;
            this.m_IPLabel.Text = "IP : ";
            // 
            // m_Port
            // 
            this.m_Port.AutoSize = true;
            this.m_Port.Location = new System.Drawing.Point(6, 67);
            this.m_Port.Name = "m_Port";
            this.m_Port.Size = new System.Drawing.Size(46, 17);
            this.m_Port.TabIndex = 3;
            this.m_Port.Text = "Port : ";
            // 
            // m_IPEnter
            // 
            this.m_IPEnter.Location = new System.Drawing.Point(478, 62);
            this.m_IPEnter.Name = "m_IPEnter";
            this.m_IPEnter.Size = new System.Drawing.Size(89, 22);
            this.m_IPEnter.TabIndex = 4;
            this.m_IPEnter.Text = "Enter";
            this.m_IPEnter.UseVisualStyleBackColor = true;
            this.m_IPEnter.Click += new System.EventHandler(this.m_IPEnter_Click);
            // 
            // m_Connect
            // 
            this.m_Connect.Enabled = false;
            this.m_Connect.Location = new System.Drawing.Point(232, 254);
            this.m_Connect.Name = "m_Connect";
            this.m_Connect.Size = new System.Drawing.Size(160, 22);
            this.m_Connect.TabIndex = 6;
            this.m_Connect.Text = "Connect";
            this.m_Connect.UseVisualStyleBackColor = true;
            this.m_Connect.Click += new System.EventHandler(this.m_Connect_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fdasToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 28);
            // 
            // fdasToolStripMenuItem
            // 
            this.fdasToolStripMenuItem.Name = "fdasToolStripMenuItem";
            this.fdasToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.fdasToolStripMenuItem.Text = "fdas";
            // 
            // m_Group1
            // 
            this.m_Group1.Controls.Add(this.m_IPLabel);
            this.m_Group1.Controls.Add(this.m_IpBoxClient1);
            this.m_Group1.Controls.Add(this.m_Port);
            this.m_Group1.Controls.Add(this.m_PortBoxClient1);
            this.m_Group1.Location = new System.Drawing.Point(12, 12);
            this.m_Group1.Name = "m_Group1";
            this.m_Group1.Size = new System.Drawing.Size(209, 108);
            this.m_Group1.TabIndex = 7;
            this.m_Group1.TabStop = false;
            this.m_Group1.Text = "Client1";
            // 
            // m_Group2
            // 
            this.m_Group2.Controls.Add(this.m_IP2);
            this.m_Group2.Controls.Add(this.m_IpBoxClient2);
            this.m_Group2.Controls.Add(this.m_Port2);
            this.m_Group2.Controls.Add(this.m_PortBoxClient2);
            this.m_Group2.Location = new System.Drawing.Point(263, 12);
            this.m_Group2.Name = "m_Group2";
            this.m_Group2.Size = new System.Drawing.Size(209, 108);
            this.m_Group2.TabIndex = 8;
            this.m_Group2.TabStop = false;
            this.m_Group2.Text = "Client2";
            // 
            // m_IP2
            // 
            this.m_IP2.AutoSize = true;
            this.m_IP2.Location = new System.Drawing.Point(6, 26);
            this.m_IP2.Name = "m_IP2";
            this.m_IP2.Size = new System.Drawing.Size(32, 17);
            this.m_IP2.TabIndex = 2;
            this.m_IP2.Text = "IP : ";
            // 
            // m_IpBoxClient2
            // 
            this.m_IpBoxClient2.Location = new System.Drawing.Point(58, 21);
            this.m_IpBoxClient2.Name = "m_IpBoxClient2";
            this.m_IpBoxClient2.Size = new System.Drawing.Size(126, 22);
            this.m_IpBoxClient2.TabIndex = 0;
            // 
            // m_Port2
            // 
            this.m_Port2.AutoSize = true;
            this.m_Port2.Location = new System.Drawing.Point(6, 67);
            this.m_Port2.Name = "m_Port2";
            this.m_Port2.Size = new System.Drawing.Size(46, 17);
            this.m_Port2.TabIndex = 3;
            this.m_Port2.Text = "Port : ";
            // 
            // m_PortBoxClient2
            // 
            this.m_PortBoxClient2.Location = new System.Drawing.Point(58, 62);
            this.m_PortBoxClient2.Name = "m_PortBoxClient2";
            this.m_PortBoxClient2.Size = new System.Drawing.Size(126, 22);
            this.m_PortBoxClient2.TabIndex = 1;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 288);
            this.Controls.Add(this.m_Group2);
            this.Controls.Add(this.m_Group1);
            this.Controls.Add(this.m_Connect);
            this.Controls.Add(this.m_IPEnter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.contextMenuStrip1.ResumeLayout(false);
            this.m_Group1.ResumeLayout(false);
            this.m_Group1.PerformLayout();
            this.m_Group2.ResumeLayout(false);
            this.m_Group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox m_IpBoxClient1;
        private System.Windows.Forms.TextBox m_PortBoxClient1;
        private System.Windows.Forms.Label m_IPLabel;
        private System.Windows.Forms.Label m_Port;
        private System.Windows.Forms.Button m_IPEnter;
        private System.Windows.Forms.Button m_Connect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fdasToolStripMenuItem;
        private System.Windows.Forms.GroupBox m_Group1;
        private System.Windows.Forms.GroupBox m_Group2;
        private System.Windows.Forms.Label m_IP2;
        private System.Windows.Forms.TextBox m_IpBoxClient2;
        private System.Windows.Forms.Label m_Port2;
        private System.Windows.Forms.TextBox m_PortBoxClient2;
    }
}

