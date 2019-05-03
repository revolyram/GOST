namespace Gost
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
            this.gp_1 = new System.Windows.Forms.GroupBox();
            this.gp_2 = new System.Windows.Forms.GroupBox();
            this.tb_enc_key = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_enc_text = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_dec_text = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_dec_key = new System.Windows.Forms.TextBox();
            this.bt_enc = new System.Windows.Forms.Button();
            this.bt_dec = new System.Windows.Forms.Button();
            this.gp_1.SuspendLayout();
            this.gp_2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_1
            // 
            this.gp_1.Controls.Add(this.bt_enc);
            this.gp_1.Controls.Add(this.groupBox2);
            this.gp_1.Controls.Add(this.groupBox1);
            this.gp_1.Location = new System.Drawing.Point(12, 12);
            this.gp_1.Name = "gp_1";
            this.gp_1.Size = new System.Drawing.Size(244, 316);
            this.gp_1.TabIndex = 0;
            this.gp_1.TabStop = false;
            this.gp_1.Text = "Encrypt";
            // 
            // gp_2
            // 
            this.gp_2.Controls.Add(this.bt_dec);
            this.gp_2.Controls.Add(this.groupBox3);
            this.gp_2.Controls.Add(this.groupBox4);
            this.gp_2.Location = new System.Drawing.Point(275, 12);
            this.gp_2.Name = "gp_2";
            this.gp_2.Size = new System.Drawing.Size(244, 316);
            this.gp_2.TabIndex = 1;
            this.gp_2.TabStop = false;
            this.gp_2.Text = "Decrypt";
            // 
            // tb_enc_key
            // 
            this.tb_enc_key.Location = new System.Drawing.Point(6, 21);
            this.tb_enc_key.Name = "tb_enc_key";
            this.tb_enc_key.Size = new System.Drawing.Size(220, 22);
            this.tb_enc_key.TabIndex = 2;
            this.tb_enc_key.TextChanged += new System.EventHandler(this.tb_enc_key_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_enc_key);
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 55);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "key";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_enc_text);
            this.groupBox2.Location = new System.Drawing.Point(6, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 183);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "text";
            // 
            // tb_enc_text
            // 
            this.tb_enc_text.Location = new System.Drawing.Point(6, 21);
            this.tb_enc_text.Multiline = true;
            this.tb_enc_text.Name = "tb_enc_text";
            this.tb_enc_text.Size = new System.Drawing.Size(220, 156);
            this.tb_enc_text.TabIndex = 2;
            this.tb_enc_text.TextChanged += new System.EventHandler(this.tb_enc_text_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_dec_text);
            this.groupBox3.Location = new System.Drawing.Point(6, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 183);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "text";
            // 
            // tb_dec_text
            // 
            this.tb_dec_text.Location = new System.Drawing.Point(6, 21);
            this.tb_dec_text.Multiline = true;
            this.tb_dec_text.Name = "tb_dec_text";
            this.tb_dec_text.Size = new System.Drawing.Size(220, 156);
            this.tb_dec_text.TabIndex = 2;
            this.tb_dec_text.TextChanged += new System.EventHandler(this.tb_dec_text_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_dec_key);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 55);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "key";
            // 
            // tb_dec_key
            // 
            this.tb_dec_key.Location = new System.Drawing.Point(6, 21);
            this.tb_dec_key.Name = "tb_dec_key";
            this.tb_dec_key.Size = new System.Drawing.Size(220, 22);
            this.tb_dec_key.TabIndex = 2;
            this.tb_dec_key.TextChanged += new System.EventHandler(this.tb_dec_key_TextChanged);
            // 
            // bt_enc
            // 
            this.bt_enc.Location = new System.Drawing.Point(6, 271);
            this.bt_enc.Name = "bt_enc";
            this.bt_enc.Size = new System.Drawing.Size(232, 39);
            this.bt_enc.TabIndex = 2;
            this.bt_enc.Text = "Encrypt";
            this.bt_enc.UseVisualStyleBackColor = true;
            this.bt_enc.Click += new System.EventHandler(this.bt_enc_Click);
            // 
            // bt_dec
            // 
            this.bt_dec.Location = new System.Drawing.Point(6, 271);
            this.bt_dec.Name = "bt_dec";
            this.bt_dec.Size = new System.Drawing.Size(232, 39);
            this.bt_dec.TabIndex = 6;
            this.bt_dec.Text = "Decrypt";
            this.bt_dec.UseVisualStyleBackColor = true;
            this.bt_dec.Click += new System.EventHandler(this.bt_dec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 339);
            this.Controls.Add(this.gp_2);
            this.Controls.Add(this.gp_1);
            this.Name = "Form1";
            this.Text = "Gost";
            this.gp_1.ResumeLayout(false);
            this.gp_2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_1;
        private System.Windows.Forms.Button bt_enc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_enc_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_enc_key;
        private System.Windows.Forms.GroupBox gp_2;
        private System.Windows.Forms.Button bt_dec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_dec_text;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_dec_key;
    }
}