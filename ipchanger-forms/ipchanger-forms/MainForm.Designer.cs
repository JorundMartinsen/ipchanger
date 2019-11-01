namespace ipchanger_forms {
    partial class MainMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblInterface;
            this.radioFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.cmbInterfaces = new System.Windows.Forms.ComboBox();
            this.grpSetConfiguration = new System.Windows.Forms.GroupBox();
            this.grpCurrentSettings = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDNS2 = new System.Windows.Forms.Label();
            this.lblDNS1 = new System.Windows.Forms.Label();
            this.lblDefaultGateway = new System.Windows.Forms.Label();
            this.lblSubnetMask = new System.Windows.Forms.Label();
            this.lblCurrentIp = new System.Windows.Forms.Label();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            lblInterface = new System.Windows.Forms.Label();
            this.grpSetConfiguration.SuspendLayout();
            this.grpCurrentSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInterface
            // 
            lblInterface.AutoSize = true;
            lblInterface.Location = new System.Drawing.Point(8, 26);
            lblInterface.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInterface.Name = "lblInterface";
            lblInterface.Size = new System.Drawing.Size(63, 17);
            lblInterface.TabIndex = 2;
            lblInterface.Text = "Interface";
            lblInterface.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioFlowPanel
            // 
            this.radioFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.radioFlowPanel.Location = new System.Drawing.Point(12, 55);
            this.radioFlowPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioFlowPanel.Name = "radioFlowPanel";
            this.radioFlowPanel.Size = new System.Drawing.Size(404, 410);
            this.radioFlowPanel.TabIndex = 0;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem5,
            this.menuItem8,
            this.menuItem6});
            this.menuItem1.Text = "File";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "Edit configuration";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.Text = "Exit";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem7});
            this.menuItem2.Text = "About";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Settings";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "Info";
            // 
            // cmbInterfaces
            // 
            this.cmbInterfaces.Location = new System.Drawing.Point(81, 22);
            this.cmbInterfaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbInterfaces.Name = "cmbInterfaces";
            this.cmbInterfaces.Size = new System.Drawing.Size(333, 24);
            this.cmbInterfaces.TabIndex = 3;
            // 
            // grpSetConfiguration
            // 
            this.grpSetConfiguration.Controls.Add(lblInterface);
            this.grpSetConfiguration.Controls.Add(this.radioFlowPanel);
            this.grpSetConfiguration.Controls.Add(this.cmbInterfaces);
            this.grpSetConfiguration.Location = new System.Drawing.Point(16, 15);
            this.grpSetConfiguration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSetConfiguration.Name = "grpSetConfiguration";
            this.grpSetConfiguration.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSetConfiguration.Size = new System.Drawing.Size(427, 473);
            this.grpSetConfiguration.TabIndex = 3;
            this.grpSetConfiguration.TabStop = false;
            this.grpSetConfiguration.Text = "Set configuration";
            // 
            // grpCurrentSettings
            // 
            this.grpCurrentSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCurrentSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpCurrentSettings.Controls.Add(this.textBox6);
            this.grpCurrentSettings.Controls.Add(this.textBox5);
            this.grpCurrentSettings.Controls.Add(this.textBox4);
            this.grpCurrentSettings.Controls.Add(this.textBox3);
            this.grpCurrentSettings.Controls.Add(this.textBox1);
            this.grpCurrentSettings.Controls.Add(this.lblDNS2);
            this.grpCurrentSettings.Controls.Add(this.lblDNS1);
            this.grpCurrentSettings.Controls.Add(this.lblDefaultGateway);
            this.grpCurrentSettings.Controls.Add(this.lblSubnetMask);
            this.grpCurrentSettings.Controls.Add(this.lblCurrentIp);
            this.grpCurrentSettings.Location = new System.Drawing.Point(451, 15);
            this.grpCurrentSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCurrentSettings.Name = "grpCurrentSettings";
            this.grpCurrentSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpCurrentSettings.Size = new System.Drawing.Size(419, 473);
            this.grpCurrentSettings.TabIndex = 4;
            this.grpCurrentSettings.TabStop = false;
            this.grpCurrentSettings.Text = "Current settings";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(180, 58);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(229, 22);
            this.textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(180, 90);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(229, 22);
            this.textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(180, 122);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 22);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(180, 154);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 22);
            this.textBox3.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(180, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 22);
            this.textBox1.TabIndex = 4;
            // 
            // lblDNS2
            // 
            this.lblDNS2.AutoSize = true;
            this.lblDNS2.Location = new System.Drawing.Point(8, 158);
            this.lblDNS2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNS2.Name = "lblDNS2";
            this.lblDNS2.Size = new System.Drawing.Size(142, 17);
            this.lblDNS2.TabIndex = 2;
            this.lblDNS2.Text = "Alternate DNS server";
            // 
            // lblDNS1
            // 
            this.lblDNS1.AutoSize = true;
            this.lblDNS1.Location = new System.Drawing.Point(8, 126);
            this.lblDNS1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNS1.Name = "lblDNS1";
            this.lblDNS1.Size = new System.Drawing.Size(145, 17);
            this.lblDNS1.TabIndex = 3;
            this.lblDNS1.Text = "Preferred DNS server";
            // 
            // lblDefaultGateway
            // 
            this.lblDefaultGateway.AutoSize = true;
            this.lblDefaultGateway.Location = new System.Drawing.Point(8, 94);
            this.lblDefaultGateway.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDefaultGateway.Name = "lblDefaultGateway";
            this.lblDefaultGateway.Size = new System.Drawing.Size(109, 17);
            this.lblDefaultGateway.TabIndex = 0;
            this.lblDefaultGateway.Text = "Default gateway";
            // 
            // lblSubnetMask
            // 
            this.lblSubnetMask.AutoSize = true;
            this.lblSubnetMask.Location = new System.Drawing.Point(8, 62);
            this.lblSubnetMask.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubnetMask.Name = "lblSubnetMask";
            this.lblSubnetMask.Size = new System.Drawing.Size(90, 17);
            this.lblSubnetMask.TabIndex = 0;
            this.lblSubnetMask.Text = "Subnet mask";
            // 
            // lblCurrentIp
            // 
            this.lblCurrentIp.AutoSize = true;
            this.lblCurrentIp.Location = new System.Drawing.Point(8, 30);
            this.lblCurrentIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentIp.Name = "lblCurrentIp";
            this.lblCurrentIp.Size = new System.Drawing.Size(75, 17);
            this.lblCurrentIp.TabIndex = 0;
            this.lblCurrentIp.Text = "IP address";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Add configuration";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "-";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 502);
            this.Controls.Add(this.grpCurrentSettings);
            this.Controls.Add(this.grpSetConfiguration);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Menu = this.mainMenu1;
            this.Name = "MainMenu";
            this.Text = "Ip Changer";
            this.grpSetConfiguration.ResumeLayout(false);
            this.grpSetConfiguration.PerformLayout();
            this.grpCurrentSettings.ResumeLayout(false);
            this.grpCurrentSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel radioFlowPanel;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.ComboBox cmbInterfaces;
        private System.Windows.Forms.GroupBox grpSetConfiguration;
        private System.Windows.Forms.GroupBox grpCurrentSettings;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDNS2;
        private System.Windows.Forms.Label lblDNS1;
        private System.Windows.Forms.Label lblDefaultGateway;
        private System.Windows.Forms.Label lblSubnetMask;
        private System.Windows.Forms.Label lblCurrentIp;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem8;
    }
}

