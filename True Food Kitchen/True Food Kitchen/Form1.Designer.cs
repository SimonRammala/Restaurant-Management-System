namespace True_Food_Kitchen
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
            this.lblheader = new System.Windows.Forms.Label();
            this.lblsub_header = new System.Windows.Forms.Label();
            this.rdbYES = new System.Windows.Forms.RadioButton();
            this.rdbNO = new System.Windows.Forms.RadioButton();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Lucida Sans", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(257, 9);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(304, 39);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "The True Kitchen";
            // 
            // lblsub_header
            // 
            this.lblsub_header.AutoSize = true;
            this.lblsub_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsub_header.Location = new System.Drawing.Point(230, 94);
            this.lblsub_header.Name = "lblsub_header";
            this.lblsub_header.Size = new System.Drawing.Size(362, 29);
            this.lblsub_header.TabIndex = 2;
            this.lblsub_header.Text = "Would you like to place a order  :";
            // 
            // rdbYES
            // 
            this.rdbYES.AutoSize = true;
            this.rdbYES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbYES.Location = new System.Drawing.Point(296, 178);
            this.rdbYES.Name = "rdbYES";
            this.rdbYES.Size = new System.Drawing.Size(55, 24);
            this.rdbYES.TabIndex = 3;
            this.rdbYES.TabStop = true;
            this.rdbYES.Text = "Yes";
            this.rdbYES.UseVisualStyleBackColor = true;
            // 
            // rdbNO
            // 
            this.rdbNO.AutoSize = true;
            this.rdbNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNO.Location = new System.Drawing.Point(448, 178);
            this.rdbNO.Name = "rdbNO";
            this.rdbNO.Size = new System.Drawing.Size(47, 24);
            this.rdbNO.TabIndex = 4;
            this.rdbNO.TabStop = true;
            this.rdbNO.Text = "No";
            this.rdbNO.UseVisualStyleBackColor = true;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.Location = new System.Drawing.Point(338, 229);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(115, 38);
            this.btnconfirm.TabIndex = 5;
            this.btnconfirm.Text = " Confirm";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 288);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.rdbNO);
            this.Controls.Add(this.rdbYES);
            this.Controls.Add(this.lblsub_header);
            this.Controls.Add(this.lblheader);
            this.Name = "Form1";
            this.Text = "Welcome page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblsub_header;
        private System.Windows.Forms.RadioButton rdbYES;
        private System.Windows.Forms.RadioButton rdbNO;
        private System.Windows.Forms.Button btnconfirm;
    }
}

