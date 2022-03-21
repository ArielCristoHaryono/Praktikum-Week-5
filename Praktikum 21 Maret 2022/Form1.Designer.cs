namespace Praktikum_21_Maret_2022
{
    partial class FormMateri
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblData = new System.Windows.Forms.Label();
            this.txtBoxData = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblKoleksi = new System.Windows.Forms.Label();
            this.lblSetting = new System.Windows.Forms.Label();
            this.chckBoxAktif = new System.Windows.Forms.CheckBox();
            this.rdioBtnMerah = new System.Windows.Forms.RadioButton();
            this.rdioBtnBiru = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(48, 66);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 25);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // txtBoxData
            // 
            this.txtBoxData.Location = new System.Drawing.Point(138, 12);
            this.txtBoxData.Name = "txtBoxData";
            this.txtBoxData.Size = new System.Drawing.Size(439, 31);
            this.txtBoxData.TabIndex = 1;
            this.txtBoxData.TextChanged += new System.EventHandler(this.txtBoxData_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(597, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblKoleksi
            // 
            this.lblKoleksi.AutoSize = true;
            this.lblKoleksi.Location = new System.Drawing.Point(48, 115);
            this.lblKoleksi.Name = "lblKoleksi";
            this.lblKoleksi.Size = new System.Drawing.Size(71, 25);
            this.lblKoleksi.TabIndex = 3;
            this.lblKoleksi.Text = "Koleksi:";
            this.lblKoleksi.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Location = new System.Drawing.Point(425, 115);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(72, 25);
            this.lblSetting.TabIndex = 4;
            this.lblSetting.Text = "Setting:";
            // 
            // chckBoxAktif
            // 
            this.chckBoxAktif.AutoSize = true;
            this.chckBoxAktif.Location = new System.Drawing.Point(513, 114);
            this.chckBoxAktif.Name = "chckBoxAktif";
            this.chckBoxAktif.Size = new System.Drawing.Size(80, 29);
            this.chckBoxAktif.TabIndex = 5;
            this.chckBoxAktif.Text = "Aktif ";
            this.chckBoxAktif.UseVisualStyleBackColor = true;
            this.chckBoxAktif.CheckedChanged += new System.EventHandler(this.chckBoxAktif_CheckedChanged);
            // 
            // rdioBtnMerah
            // 
            this.rdioBtnMerah.AutoSize = true;
            this.rdioBtnMerah.Checked = true;
            this.rdioBtnMerah.Location = new System.Drawing.Point(476, 149);
            this.rdioBtnMerah.Name = "rdioBtnMerah";
            this.rdioBtnMerah.Size = new System.Drawing.Size(147, 29);
            this.rdioBtnMerah.TabIndex = 6;
            this.rdioBtnMerah.TabStop = true;
            this.rdioBtnMerah.Text = "Warna Merah ";
            this.rdioBtnMerah.UseVisualStyleBackColor = true;
            this.rdioBtnMerah.CheckedChanged += new System.EventHandler(this.rdioBtnMerah_CheckedChanged);
            // 
            // rdioBtnBiru
            // 
            this.rdioBtnBiru.AutoSize = true;
            this.rdioBtnBiru.Location = new System.Drawing.Point(476, 193);
            this.rdioBtnBiru.Name = "rdioBtnBiru";
            this.rdioBtnBiru.Size = new System.Drawing.Size(132, 29);
            this.rdioBtnBiru.TabIndex = 7;
            this.rdioBtnBiru.TabStop = true;
            this.rdioBtnBiru.Text = "Warna Biru  ";
            this.rdioBtnBiru.UseVisualStyleBackColor = true;
            this.rdioBtnBiru.CheckedChanged += new System.EventHandler(this.rdioBtnBiru_CheckedChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(424, 273);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(73, 25);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "Output:";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(534, 350);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(24, 25);
            this.labelOutput.TabIndex = 10;
            this.labelOutput.Text = "...";
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(425, 433);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(284, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 25;
            this.listBoxData.Location = new System.Drawing.Point(48, 163);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(345, 304);
            this.listBoxData.TabIndex = 8;
            this.listBoxData.SelectedIndexChanged += new System.EventHandler(this.listBoxData_SelectedIndexChanged);
            // 
            // FormMateri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.rdioBtnBiru);
            this.Controls.Add(this.rdioBtnMerah);
            this.Controls.Add(this.chckBoxAktif);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.lblKoleksi);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxData);
            this.Controls.Add(this.lblData);
            this.Name = "FormMateri";
            this.Text = "Form Materi ";
            this.Load += new System.EventHandler(this.FormMateri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtBoxData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblKoleksi;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.CheckBox chckBoxAktif;
        private System.Windows.Forms.RadioButton rdioBtnMerah;
        private System.Windows.Forms.RadioButton rdioBtnBiru;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listBoxData;
    }
}
