namespace CAN_PGN_SIM_4p7p2.CustomUserControls.SimulaUC
{
    partial class VC_PGN_ColCtrlr_UC
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
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.my_2x8_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.my_uc_PgnDataDisplay = new CAN_PGN_SIM_4p7p2.CustomUserControls.Utils.uc_PgnDataDisplay();
            this.SuspendLayout();
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Desc.Location = new System.Drawing.Point(0, 0);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(79, 29);
            this.lbl_Desc.TabIndex = 0;
            this.lbl_Desc.Text = "label1";
            // 
            // my_2x8_tableLayoutPanel
            // 
            this.my_2x8_tableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.my_2x8_tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.my_2x8_tableLayoutPanel.ColumnCount = 2;
            this.my_2x8_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.my_2x8_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 801F));
            this.my_2x8_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.my_2x8_tableLayoutPanel.Location = new System.Drawing.Point(0, 160);
            this.my_2x8_tableLayoutPanel.Name = "my_2x8_tableLayoutPanel";
            this.my_2x8_tableLayoutPanel.RowCount = 8;
            this.my_2x8_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.my_2x8_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.my_2x8_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.my_2x8_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.my_2x8_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.my_2x8_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.my_2x8_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.my_2x8_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.my_2x8_tableLayoutPanel.Size = new System.Drawing.Size(900, 1840);
            this.my_2x8_tableLayoutPanel.TabIndex = 2;
            // 
            // my_uc_PgnDataDisplay
            // 
            this.my_uc_PgnDataDisplay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.my_uc_PgnDataDisplay.Location = new System.Drawing.Point(0, 34);
            this.my_uc_PgnDataDisplay.Name = "my_uc_PgnDataDisplay";
            this.my_uc_PgnDataDisplay.Size = new System.Drawing.Size(900, 120);
            this.my_uc_PgnDataDisplay.TabIndex = 3;
            // 
            // VC_PGN_ColCtrlr_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.my_uc_PgnDataDisplay);
            this.Controls.Add(this.my_2x8_tableLayoutPanel);
            this.Controls.Add(this.lbl_Desc);
            this.Name = "VC_PGN_ColCtrlr_UC";
            this.Size = new System.Drawing.Size(900, 2000);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.TableLayoutPanel my_2x8_tableLayoutPanel;
        private Utils.uc_PgnDataDisplay my_uc_PgnDataDisplay;
    }
}
