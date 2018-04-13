namespace SmartPad
{
    partial class frmSplash
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
            this.lblProfileSelect = new System.Windows.Forms.Label();
            this.cboProfileSelect = new System.Windows.Forms.ComboBox();
            this.btnOpenApp = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtNewProfile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProfileSelect
            // 
            this.lblProfileSelect.AutoSize = true;
            this.lblProfileSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileSelect.Location = new System.Drawing.Point(85, 69);
            this.lblProfileSelect.Name = "lblProfileSelect";
            this.lblProfileSelect.Size = new System.Drawing.Size(193, 17);
            this.lblProfileSelect.TabIndex = 0;
            this.lblProfileSelect.Text = "Please select your profile";
            // 
            // cboProfileSelect
            // 
            this.cboProfileSelect.FormattingEnabled = true;
            this.cboProfileSelect.Location = new System.Drawing.Point(88, 101);
            this.cboProfileSelect.Name = "cboProfileSelect";
            this.cboProfileSelect.Size = new System.Drawing.Size(190, 21);
            this.cboProfileSelect.TabIndex = 1;
            // 
            // btnOpenApp
            // 
            this.btnOpenApp.Location = new System.Drawing.Point(126, 185);
            this.btnOpenApp.Name = "btnOpenApp";
            this.btnOpenApp.Size = new System.Drawing.Size(118, 23);
            this.btnOpenApp.TabIndex = 3;
            this.btnOpenApp.Text = "Open SmartPad";
            this.btnOpenApp.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(84, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(187, 20);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to SmartPad";
            // 
            // txtNewProfile
            // 
            this.txtNewProfile.Location = new System.Drawing.Point(88, 143);
            this.txtNewProfile.Name = "txtNewProfile";
            this.txtNewProfile.Size = new System.Drawing.Size(190, 20);
            this.txtNewProfile.TabIndex = 5;
            this.txtNewProfile.Visible = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 250);
            this.ControlBox = false;
            this.Controls.Add(this.txtNewProfile);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnOpenApp);
            this.Controls.Add(this.cboProfileSelect);
            this.Controls.Add(this.lblProfileSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfileSelect;
        private System.Windows.Forms.ComboBox cboProfileSelect;
        private System.Windows.Forms.Button btnOpenApp;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtNewProfile;
    }
}

