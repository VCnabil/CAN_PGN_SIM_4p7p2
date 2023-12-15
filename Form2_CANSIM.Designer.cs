namespace CAN_PGN_SIM_4p7p2
{
    partial class Form2_CANSIM
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_RunLoop = new System.Windows.Forms.Button();
            this.timer1_Loop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(2309, 1180);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btn_RunLoop
            // 
            this.btn_RunLoop.Location = new System.Drawing.Point(32, -1);
            this.btn_RunLoop.Name = "btn_RunLoop";
            this.btn_RunLoop.Size = new System.Drawing.Size(110, 53);
            this.btn_RunLoop.TabIndex = 6;
            this.btn_RunLoop.Text = "button1";
            this.btn_RunLoop.UseVisualStyleBackColor = true;
            // 
            // Form2_CANSIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(2372, 1296);
            this.Controls.Add(this.btn_RunLoop);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form2_CANSIM";
            this.Text = "Form2_CANSIM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_RunLoop;
        private System.Windows.Forms.Timer timer1_Loop;
    }
}