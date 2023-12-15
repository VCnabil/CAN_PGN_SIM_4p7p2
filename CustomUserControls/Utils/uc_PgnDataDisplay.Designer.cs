namespace CAN_PGN_SIM_4p7p2.CustomUserControls.Utils
{
    partial class uc_PgnDataDisplay
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
            this.mlbl_Title = new System.Windows.Forms.Label();
            this.mcb_Hex = new System.Windows.Forms.CheckBox();
            this.mlbl_B0 = new System.Windows.Forms.Label();
            this.mlbl_B1 = new System.Windows.Forms.Label();
            this.mlbl_B2 = new System.Windows.Forms.Label();
            this.mlbl_B3 = new System.Windows.Forms.Label();
            this.mlbl_B4 = new System.Windows.Forms.Label();
            this.mlbl_B5 = new System.Windows.Forms.Label();
            this.mlbl_B6 = new System.Windows.Forms.Label();
            this.mlbl_B7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.mlbl_B7, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlbl_B6, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlbl_B5, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlbl_B4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlbl_B3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlbl_B2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlbl_B1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mlbl_B0, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mcb_Hex, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.mlbl_Title, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 120);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // mlbl_Title
            // 
            this.mlbl_Title.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.mlbl_Title, 3);
            this.mlbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlbl_Title.Location = new System.Drawing.Point(3, 0);
            this.mlbl_Title.Name = "mlbl_Title";
            this.mlbl_Title.Size = new System.Drawing.Size(330, 60);
            this.mlbl_Title.TabIndex = 2;
            this.mlbl_Title.Text = "title pgn 0x18ff2000";
            this.mlbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mcb_Hex
            // 
            this.mcb_Hex.AutoSize = true;
            this.mcb_Hex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcb_Hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F);
            this.mcb_Hex.Location = new System.Drawing.Point(339, 3);
            this.mcb_Hex.Name = "mcb_Hex";
            this.mcb_Hex.Size = new System.Drawing.Size(106, 54);
            this.mcb_Hex.TabIndex = 14;
            this.mcb_Hex.Text = "HEX";
            this.mcb_Hex.UseVisualStyleBackColor = true;
            // 
            // mlbl_B0
            // 
            this.mlbl_B0.AutoSize = true;
            this.mlbl_B0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbl_B0.Location = new System.Drawing.Point(3, 60);
            this.mlbl_B0.Name = "mlbl_B0";
            this.mlbl_B0.Size = new System.Drawing.Size(106, 60);
            this.mlbl_B0.TabIndex = 21;
            this.mlbl_B0.Text = "255";
            this.mlbl_B0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlbl_B1
            // 
            this.mlbl_B1.AutoSize = true;
            this.mlbl_B1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbl_B1.Location = new System.Drawing.Point(115, 60);
            this.mlbl_B1.Name = "mlbl_B1";
            this.mlbl_B1.Size = new System.Drawing.Size(106, 60);
            this.mlbl_B1.TabIndex = 22;
            this.mlbl_B1.Text = "255";
            this.mlbl_B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlbl_B2
            // 
            this.mlbl_B2.AutoSize = true;
            this.mlbl_B2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbl_B2.Location = new System.Drawing.Point(227, 60);
            this.mlbl_B2.Name = "mlbl_B2";
            this.mlbl_B2.Size = new System.Drawing.Size(106, 60);
            this.mlbl_B2.TabIndex = 23;
            this.mlbl_B2.Text = "255";
            this.mlbl_B2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlbl_B3
            // 
            this.mlbl_B3.AutoSize = true;
            this.mlbl_B3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbl_B3.Location = new System.Drawing.Point(339, 60);
            this.mlbl_B3.Name = "mlbl_B3";
            this.mlbl_B3.Size = new System.Drawing.Size(106, 60);
            this.mlbl_B3.TabIndex = 24;
            this.mlbl_B3.Text = "255";
            this.mlbl_B3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlbl_B4
            // 
            this.mlbl_B4.AutoSize = true;
            this.mlbl_B4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbl_B4.Location = new System.Drawing.Point(451, 60);
            this.mlbl_B4.Name = "mlbl_B4";
            this.mlbl_B4.Size = new System.Drawing.Size(106, 60);
            this.mlbl_B4.TabIndex = 25;
            this.mlbl_B4.Text = "255";
            this.mlbl_B4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlbl_B5
            // 
            this.mlbl_B5.AutoSize = true;
            this.mlbl_B5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbl_B5.Location = new System.Drawing.Point(563, 60);
            this.mlbl_B5.Name = "mlbl_B5";
            this.mlbl_B5.Size = new System.Drawing.Size(106, 60);
            this.mlbl_B5.TabIndex = 26;
            this.mlbl_B5.Text = "255";
            this.mlbl_B5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlbl_B6
            // 
            this.mlbl_B6.AutoSize = true;
            this.mlbl_B6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbl_B6.Location = new System.Drawing.Point(675, 60);
            this.mlbl_B6.Name = "mlbl_B6";
            this.mlbl_B6.Size = new System.Drawing.Size(106, 60);
            this.mlbl_B6.TabIndex = 27;
            this.mlbl_B6.Text = "255";
            this.mlbl_B6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlbl_B7
            // 
            this.mlbl_B7.AutoSize = true;
            this.mlbl_B7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mlbl_B7.Location = new System.Drawing.Point(787, 60);
            this.mlbl_B7.Name = "mlbl_B7";
            this.mlbl_B7.Size = new System.Drawing.Size(110, 60);
            this.mlbl_B7.TabIndex = 28;
            this.mlbl_B7.Text = "255";
            this.mlbl_B7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_PgnDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uc_PgnDataDisplay";
            this.Size = new System.Drawing.Size(900, 120);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label mlbl_Title;
        private System.Windows.Forms.CheckBox mcb_Hex;
        private System.Windows.Forms.Label mlbl_B7;
        private System.Windows.Forms.Label mlbl_B6;
        private System.Windows.Forms.Label mlbl_B5;
        private System.Windows.Forms.Label mlbl_B4;
        private System.Windows.Forms.Label mlbl_B3;
        private System.Windows.Forms.Label mlbl_B2;
        private System.Windows.Forms.Label mlbl_B1;
        private System.Windows.Forms.Label mlbl_B0;
    }
}
