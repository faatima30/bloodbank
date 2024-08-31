namespace SIUbloodbank
{
    partial class Blooddonor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dtpdonordate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnaction = new System.Windows.Forms.Button();
            this.cmbdonornames = new System.Windows.Forms.ComboBox();
            this.txtbloodtype = new System.Windows.Forms.TextBox();
            this.dgvblooddonor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvblooddonor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Donor name:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(271, 151);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(399, 34);
            this.txtQuantity.TabIndex = 2;
            // 
            // dtpdonordate
            // 
            this.dtpdonordate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdonordate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdonordate.Location = new System.Drawing.Point(271, 211);
            this.dtpdonordate.Name = "dtpdonordate";
            this.dtpdonordate.Size = new System.Drawing.Size(399, 34);
            this.dtpdonordate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bloodtype:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date:";
            // 
            // btnaction
            // 
            this.btnaction.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaction.Location = new System.Drawing.Point(271, 270);
            this.btnaction.Name = "btnaction";
            this.btnaction.Size = new System.Drawing.Size(112, 40);
            this.btnaction.TabIndex = 4;
            this.btnaction.Text = "Save";
            this.btnaction.UseVisualStyleBackColor = true;
            this.btnaction.Click += new System.EventHandler(this.Btnaction_Click);
            // 
            // cmbdonornames
            // 
            this.cmbdonornames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdonornames.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdonornames.FormattingEnabled = true;
            this.cmbdonornames.Location = new System.Drawing.Point(271, 37);
            this.cmbdonornames.Name = "cmbdonornames";
            this.cmbdonornames.Size = new System.Drawing.Size(399, 34);
            this.cmbdonornames.TabIndex = 1;
            this.cmbdonornames.SelectedIndexChanged += new System.EventHandler(this.Cmbdonornames_SelectedIndexChanged);
            // 
            // txtbloodtype
            // 
            this.txtbloodtype.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbloodtype.Location = new System.Drawing.Point(271, 97);
            this.txtbloodtype.Name = "txtbloodtype";
            this.txtbloodtype.ReadOnly = true;
            this.txtbloodtype.Size = new System.Drawing.Size(399, 34);
            this.txtbloodtype.TabIndex = 9;
            this.txtbloodtype.TabStop = false;
            // 
            // dgvblooddonor
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvblooddonor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvblooddonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvblooddonor.Location = new System.Drawing.Point(13, 355);
            this.dgvblooddonor.Name = "dgvblooddonor";
            this.dgvblooddonor.ReadOnly = true;
            this.dgvblooddonor.RowTemplate.Height = 24;
            this.dgvblooddonor.Size = new System.Drawing.Size(684, 365);
            this.dgvblooddonor.TabIndex = 10;
            this.dgvblooddonor.TabStop = false;
            this.dgvblooddonor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvblooddonor_CellClick);
            // 
            // Blooddonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 732);
            this.Controls.Add(this.dgvblooddonor);
            this.Controls.Add(this.txtbloodtype);
            this.Controls.Add(this.btnaction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpdonordate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbdonornames);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Blooddonor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood donor";
            this.Load += new System.EventHandler(this.Blooddonor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvblooddonor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dtpdonordate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnaction;
        private System.Windows.Forms.ComboBox cmbdonornames;
        private System.Windows.Forms.TextBox txtbloodtype;
        private System.Windows.Forms.DataGridView dgvblooddonor;
    }
}