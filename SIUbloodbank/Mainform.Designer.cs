namespace SIUbloodbank
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.msSIUBloodBank = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodSeekerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBloodBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodBankToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msSIUBloodBank.SuspendLayout();
            this.SuspendLayout();
            // 
            // msSIUBloodBank
            // 
            this.msSIUBloodBank.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msSIUBloodBank.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msSIUBloodBank.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.registrationsToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.msSIUBloodBank.Location = new System.Drawing.Point(0, 0);
            this.msSIUBloodBank.Name = "msSIUBloodBank";
            this.msSIUBloodBank.Size = new System.Drawing.Size(1208, 49);
            this.msSIUBloodBank.TabIndex = 0;
            this.msSIUBloodBank.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(128, 45);
            this.settingToolStripMenuItem.Text = "&Setting";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(205, 46);
            this.logOutToolStripMenuItem.Text = "&LogOut";
            // 
            // registrationsToolStripMenuItem
            // 
            this.registrationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.donorsToolStripMenuItem});
            this.registrationsToolStripMenuItem.Name = "registrationsToolStripMenuItem";
            this.registrationsToolStripMenuItem.Size = new System.Drawing.Size(209, 45);
            this.registrationsToolStripMenuItem.Text = "&Registrations";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(202, 46);
            this.usersToolStripMenuItem.Text = "&Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.UsersToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(202, 46);
            this.donorsToolStripMenuItem.Text = "&Donors";
            this.donorsToolStripMenuItem.Click += new System.EventHandler(this.DonorsToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloodBankToolStripMenuItem,
            this.bloodSeekerToolStripMenuItem,
            this.viewBloodBankToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(289, 45);
            this.transactionToolStripMenuItem.Text = "&Blood Transactions";
            // 
            // bloodBankToolStripMenuItem
            // 
            this.bloodBankToolStripMenuItem.Name = "bloodBankToolStripMenuItem";
            this.bloodBankToolStripMenuItem.Size = new System.Drawing.Size(328, 46);
            this.bloodBankToolStripMenuItem.Text = "Blo&od Donor";
            this.bloodBankToolStripMenuItem.Click += new System.EventHandler(this.BloodBankToolStripMenuItem_Click);
            // 
            // bloodSeekerToolStripMenuItem
            // 
            this.bloodSeekerToolStripMenuItem.Name = "bloodSeekerToolStripMenuItem";
            this.bloodSeekerToolStripMenuItem.Size = new System.Drawing.Size(328, 46);
            this.bloodSeekerToolStripMenuItem.Text = "Blood &Seeker";
            this.bloodSeekerToolStripMenuItem.Click += new System.EventHandler(this.BloodSeekerToolStripMenuItem_Click);
            // 
            // viewBloodBankToolStripMenuItem
            // 
            this.viewBloodBankToolStripMenuItem.Name = "viewBloodBankToolStripMenuItem";
            this.viewBloodBankToolStripMenuItem.Size = new System.Drawing.Size(328, 46);
            this.viewBloodBankToolStripMenuItem.Text = "&view Blood Bank";
            this.viewBloodBankToolStripMenuItem.Click += new System.EventHandler(this.ViewBloodBankToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bloodBankToolStripMenuItem1});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(120, 45);
            this.searchToolStripMenuItem.Text = "Sea&rch";
            // 
            // bloodBankToolStripMenuItem1
            // 
            this.bloodBankToolStripMenuItem1.Name = "bloodBankToolStripMenuItem1";
            this.bloodBankToolStripMenuItem1.Size = new System.Drawing.Size(258, 46);
            this.bloodBankToolStripMenuItem1.Text = "Bloo&d Bank";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 751);
            this.Controls.Add(this.msSIUBloodBank);
            this.MainMenuStrip = this.msSIUBloodBank;
            this.Name = "Mainform";
            this.ShowIcon = false;
            this.Text = "siu blood bank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.msSIUBloodBank.ResumeLayout(false);
            this.msSIUBloodBank.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msSIUBloodBank;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodSeekerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodBankToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewBloodBankToolStripMenuItem;
    }
}