namespace SIUbloodbank
{
    partial class BloodSeeker
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsseekername = new System.Windows.Forms.TextBox();
            this.cmbbloodtype = new System.Windows.Forms.ComboBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnaction = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvbloodseeker = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbloodseeker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seeker Name:";
            // 
            // txtsseekername
            // 
            this.txtsseekername.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsseekername.Location = new System.Drawing.Point(261, 25);
            this.txtsseekername.Name = "txtsseekername";
            this.txtsseekername.Size = new System.Drawing.Size(495, 39);
            this.txtsseekername.TabIndex = 1;
            // 
            // cmbbloodtype
            // 
            this.cmbbloodtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbloodtype.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbloodtype.FormattingEnabled = true;
            this.cmbbloodtype.Items.AddRange(new object[] {
            "------Select Bloodtype-------",
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.cmbbloodtype.Location = new System.Drawing.Point(261, 80);
            this.cmbbloodtype.Name = "cmbbloodtype";
            this.cmbbloodtype.Size = new System.Drawing.Size(495, 39);
            this.cmbbloodtype.TabIndex = 2;
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(261, 140);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(495, 39);
            this.txtqty.TabIndex = 3;
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(261, 199);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(495, 39);
            this.dtp.TabIndex = 4;
            // 
            // btnaction
            // 
            this.btnaction.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaction.Location = new System.Drawing.Point(261, 265);
            this.btnaction.Name = "btnaction";
            this.btnaction.Size = new System.Drawing.Size(102, 48);
            this.btnaction.TabIndex = 5;
            this.btnaction.Text = "Save";
            this.btnaction.UseVisualStyleBackColor = true;
            this.btnaction.Click += new System.EventHandler(this.Btnaction_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Bloodtype:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date:";
            // 
            // dgvbloodseeker
            // 
            this.dgvbloodseeker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbloodseeker.Location = new System.Drawing.Point(28, 332);
            this.dgvbloodseeker.Name = "dgvbloodseeker";
            this.dgvbloodseeker.ReadOnly = true;
            this.dgvbloodseeker.RowTemplate.Height = 24;
            this.dgvbloodseeker.Size = new System.Drawing.Size(751, 413);
            this.dgvbloodseeker.TabIndex = 9;
            // 
            // BloodSeeker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 757);
            this.Controls.Add(this.dgvbloodseeker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaction);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.cmbbloodtype);
            this.Controls.Add(this.txtsseekername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "BloodSeeker";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blood Seeker Information";
            this.Load += new System.EventHandler(this.BloodSeeker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbloodseeker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsseekername;
        private System.Windows.Forms.ComboBox cmbbloodtype;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btnaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvbloodseeker;
    }
}