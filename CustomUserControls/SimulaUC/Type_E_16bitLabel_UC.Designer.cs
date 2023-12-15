namespace CAN_PGN_SIM_4p7p2.CustomUserControls.SimulaUC
{
    partial class Type_E_16bitLabel_UC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.tb_RawNum = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.cb_HEX = new System.Windows.Forms.CheckBox();
            this.lbl_Bval = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 345F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Desc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_RawNum, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(90, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 220);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_Desc, 2);
            this.lbl_Desc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Desc.Location = new System.Drawing.Point(3, 191);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(654, 29);
            this.lbl_Desc.TabIndex = 1;
            this.lbl_Desc.Text = "Description";
            // 
            // tb_RawNum
            // 
            this.tb_RawNum.Location = new System.Drawing.Point(318, 75);
            this.tb_RawNum.Name = "tb_RawNum";
            this.tb_RawNum.Size = new System.Drawing.Size(129, 35);
            this.tb_RawNum.TabIndex = 2;
            this.tb_RawNum.Text = "1880";
            // 
            // btn_reset
            // 
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reset.Location = new System.Drawing.Point(0, 0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(90, 49);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // cb_HEX
            // 
            this.cb_HEX.AutoSize = true;
            this.cb_HEX.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_HEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.cb_HEX.Location = new System.Drawing.Point(0, 49);
            this.cb_HEX.Name = "cb_HEX";
            this.cb_HEX.Size = new System.Drawing.Size(90, 27);
            this.cb_HEX.TabIndex = 13;
            this.cb_HEX.Text = "HEX";
            this.cb_HEX.UseVisualStyleBackColor = true;
            // 
            // lbl_Bval
            // 
            this.lbl_Bval.AutoSize = true;
            this.lbl_Bval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_Bval.Location = new System.Drawing.Point(3, 109);
            this.lbl_Bval.Name = "lbl_Bval";
            this.lbl_Bval.Size = new System.Drawing.Size(65, 29);
            this.lbl_Bval.TabIndex = 14;
            this.lbl_Bval.Text = "2550";
            // 
            // Type_E_16bitLabel_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Bval);
            this.Controls.Add(this.cb_HEX);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Type_E_16bitLabel_UC";
            this.Size = new System.Drawing.Size(750, 220);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.TextBox tb_RawNum;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.CheckBox cb_HEX;
        private System.Windows.Forms.Label lbl_Bval;
    }
}
