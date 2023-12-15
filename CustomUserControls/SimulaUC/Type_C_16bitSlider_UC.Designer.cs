namespace CAN_PGN_SIM_4p7p2.CustomUserControls.SimulaUC
{
    partial class Type_C_16bitSlider_UC
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
            this.tb_Slider = new System.Windows.Forms.TrackBar();
            this.lbl_DescLOByte = new System.Windows.Forms.Label();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.lbl_LObyteVal = new System.Windows.Forms.Label();
            this.lbl_HIbyteVal = new System.Windows.Forms.Label();
            this.lbl_DescHIByte = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.cb_HEX = new System.Windows.Forms.CheckBox();
            this.lbl_Bval = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tb_Slider, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_DescLOByte, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Desc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_LObyteVal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_HIbyteVal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_DescHIByte, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(90, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(660, 220);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tb_Slider
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tb_Slider, 2);
            this.tb_Slider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Slider.Location = new System.Drawing.Point(3, 112);
            this.tb_Slider.Name = "tb_Slider";
            this.tb_Slider.Size = new System.Drawing.Size(654, 76);
            this.tb_Slider.TabIndex = 1;
            // 
            // lbl_DescLOByte
            // 
            this.lbl_DescLOByte.AutoSize = true;
            this.lbl_DescLOByte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_DescLOByte.Location = new System.Drawing.Point(3, 82);
            this.lbl_DescLOByte.Name = "lbl_DescLOByte";
            this.lbl_DescLOByte.Size = new System.Drawing.Size(324, 27);
            this.lbl_DescLOByte.TabIndex = 2;
            this.lbl_DescLOByte.Text = "LO byte description";
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_Desc, 2);
            this.lbl_Desc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Desc.Location = new System.Drawing.Point(3, 191);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(654, 29);
            this.lbl_Desc.TabIndex = 3;
            this.lbl_Desc.Text = "Description";
            this.lbl_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LObyteVal
            // 
            this.lbl_LObyteVal.AutoSize = true;
            this.lbl_LObyteVal.Location = new System.Drawing.Point(3, 0);
            this.lbl_LObyteVal.Name = "lbl_LObyteVal";
            this.lbl_LObyteVal.Size = new System.Drawing.Size(165, 29);
            this.lbl_LObyteVal.TabIndex = 4;
            this.lbl_LObyteVal.Text = "LO Byte Value";
            // 
            // lbl_HIbyteVal
            // 
            this.lbl_HIbyteVal.AutoSize = true;
            this.lbl_HIbyteVal.Location = new System.Drawing.Point(333, 0);
            this.lbl_HIbyteVal.Name = "lbl_HIbyteVal";
            this.lbl_HIbyteVal.Size = new System.Drawing.Size(156, 29);
            this.lbl_HIbyteVal.TabIndex = 5;
            this.lbl_HIbyteVal.Text = "HI Byte Value";
            // 
            // lbl_DescHIByte
            // 
            this.lbl_DescHIByte.AutoSize = true;
            this.lbl_DescHIByte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_DescHIByte.Location = new System.Drawing.Point(333, 82);
            this.lbl_DescHIByte.Name = "lbl_DescHIByte";
            this.lbl_DescHIByte.Size = new System.Drawing.Size(324, 27);
            this.lbl_DescHIByte.TabIndex = 6;
            this.lbl_DescHIByte.Text = "Hi byte description";
            // 
            // btn_reset
            // 
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reset.Location = new System.Drawing.Point(0, 0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(90, 49);
            this.btn_reset.TabIndex = 5;
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
            this.cb_HEX.TabIndex = 6;
            this.cb_HEX.Text = "HEX";
            this.cb_HEX.UseVisualStyleBackColor = true;
            // 
            // lbl_Bval
            // 
            this.lbl_Bval.AutoSize = true;
            this.lbl_Bval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_Bval.Location = new System.Drawing.Point(3, 112);
            this.lbl_Bval.Name = "lbl_Bval";
            this.lbl_Bval.Size = new System.Drawing.Size(78, 29);
            this.lbl_Bval.TabIndex = 7;
            this.lbl_Bval.Text = "12345";
            // 
            // Type_C_16bitSlider_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Bval);
            this.Controls.Add(this.cb_HEX);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Type_C_16bitSlider_UC";
            this.Size = new System.Drawing.Size(750, 220);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar tb_Slider;
        private System.Windows.Forms.Label lbl_DescLOByte;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Label lbl_LObyteVal;
        private System.Windows.Forms.Label lbl_HIbyteVal;
        private System.Windows.Forms.Label lbl_DescHIByte;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.CheckBox cb_HEX;
        private System.Windows.Forms.Label lbl_Bval;
    }
}
