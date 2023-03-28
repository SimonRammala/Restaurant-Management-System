namespace True_Food_Kitchen
{
    partial class Welcome
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
            this.lblheader = new System.Windows.Forms.Label();
            this.lblquestion = new System.Windows.Forms.Label();
            this.rdb_yes = new System.Windows.Forms.RadioButton();
            this.rdb_no = new System.Windows.Forms.RadioButton();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(376, 25);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(523, 37);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "Welcome to the true food kitchen";
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(430, 148);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(380, 27);
            this.lblquestion.TabIndex = 1;
            this.lblquestion.Text = "Would you like to place an order ?";
            // 
            // rdb_yes
            // 
            this.rdb_yes.AutoSize = true;
            this.rdb_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_yes.Location = new System.Drawing.Point(466, 235);
            this.rdb_yes.Name = "rdb_yes";
            this.rdb_yes.Size = new System.Drawing.Size(55, 24);
            this.rdb_yes.TabIndex = 2;
            this.rdb_yes.TabStop = true;
            this.rdb_yes.Text = "Yes";
            this.rdb_yes.UseVisualStyleBackColor = true;
            // 
            // rdb_no
            // 
            this.rdb_no.AutoSize = true;
            this.rdb_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_no.Location = new System.Drawing.Point(692, 235);
            this.rdb_no.Name = "rdb_no";
            this.rdb_no.Size = new System.Drawing.Size(47, 24);
            this.rdb_no.TabIndex = 3;
            this.rdb_no.TabStop = true;
            this.rdb_no.Text = "No";
            this.rdb_no.UseVisualStyleBackColor = true;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.Location = new System.Drawing.Point(545, 289);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(128, 36);
            this.btnconfirm.TabIndex = 4;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 434);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.rdb_no);
            this.Controls.Add(this.rdb_yes);
            this.Controls.Add(this.lblquestion);
            this.Controls.Add(this.lblheader);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.RadioButton rdb_yes;
        private System.Windows.Forms.RadioButton rdb_no;
        private System.Windows.Forms.Button btnconfirm;
    }
}

