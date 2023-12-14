namespace CAN_PGN_SIM_4p7p2.CustomUserControls.ConfigUC
{
    partial class VCPGN_UC_C
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_BytesAmount = new System.Windows.Forms.Label();
            this.btn_make = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.textBox_PGN = new System.Windows.Forms.TextBox();
            this.tb_DESC = new System.Windows.Forms.TextBox();
            this.lbl_debug1 = new System.Windows.Forms.Label();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_BytesAmount
            // 
            this.lbl_BytesAmount.AutoSize = true;
            this.lbl_BytesAmount.Font = new System.Drawing.Font("Noto Mono", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BytesAmount.Location = new System.Drawing.Point(98, 36);
            this.lbl_BytesAmount.Name = "lbl_BytesAmount";
            this.lbl_BytesAmount.Size = new System.Drawing.Size(23, 24);
            this.lbl_BytesAmount.TabIndex = 59;
            this.lbl_BytesAmount.Text = "2";
            // 
            // btn_make
            // 
            this.btn_make.Font = new System.Drawing.Font("Noto Mono", 6F);
            this.btn_make.Location = new System.Drawing.Point(268, 36);
            this.btn_make.Name = "btn_make";
            this.btn_make.Size = new System.Drawing.Size(75, 34);
            this.btn_make.TabIndex = 60;
            this.btn_make.Text = "make";
            this.btn_make.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Noto Mono", 6F);
            this.btn_clear.Location = new System.Drawing.Point(364, 36);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 34);
            this.btn_clear.TabIndex = 61;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // textBox_PGN
            // 
            this.textBox_PGN.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.textBox_PGN.Font = new System.Drawing.Font("Noto Mono", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PGN.Location = new System.Drawing.Point(464, 39);
            this.textBox_PGN.Name = "textBox_PGN";
            this.textBox_PGN.Size = new System.Drawing.Size(163, 25);
            this.textBox_PGN.TabIndex = 62;
            // 
            // tb_DESC
            // 
            this.tb_DESC.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tb_DESC.Font = new System.Drawing.Font("Noto Mono", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DESC.Location = new System.Drawing.Point(5, 5);
            this.tb_DESC.Name = "tb_DESC";
            this.tb_DESC.Size = new System.Drawing.Size(818, 25);
            this.tb_DESC.TabIndex = 63;
            this.tb_DESC.Text = "what am i";
            // 
            // lbl_debug1
            // 
            this.lbl_debug1.AutoSize = true;
            this.lbl_debug1.Font = new System.Drawing.Font("Noto Mono", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_debug1.Location = new System.Drawing.Point(648, 43);
            this.lbl_debug1.Name = "lbl_debug1";
            this.lbl_debug1.Size = new System.Drawing.Size(107, 18);
            this.lbl_debug1.TabIndex = 64;
            this.lbl_debug1.Text = "forDebuggug";
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Noto Mono", 6F);
            this.btn_plus.Location = new System.Drawing.Point(149, 36);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(45, 34);
            this.btn_plus.TabIndex = 65;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Noto Mono", 6F);
            this.btn_minus.Location = new System.Drawing.Point(14, 36);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(45, 34);
            this.btn_minus.TabIndex = 66;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            // 
            // VCPGN_UC_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.lbl_debug1);
            this.Controls.Add(this.tb_DESC);
            this.Controls.Add(this.textBox_PGN);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_make);
            this.Controls.Add(this.lbl_BytesAmount);
            this.Name = "VCPGN_UC_C";
            this.Size = new System.Drawing.Size(850, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_BytesAmount;
        private System.Windows.Forms.Button btn_make;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox textBox_PGN;
        private System.Windows.Forms.TextBox tb_DESC;
        private System.Windows.Forms.Label lbl_debug1;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
    }
}
