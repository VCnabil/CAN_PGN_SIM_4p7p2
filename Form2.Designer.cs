namespace CAN_PGN_SIM_4p7p2
{
    partial class Form2
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
            this.btn_RunLoop = new System.Windows.Forms.Button();
            this.timer1_Loop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_RunLoop
            // 
            this.btn_RunLoop.Location = new System.Drawing.Point(13, 13);
            this.btn_RunLoop.Name = "btn_RunLoop";
            this.btn_RunLoop.Size = new System.Drawing.Size(98, 37);
            this.btn_RunLoop.TabIndex = 0;
            this.btn_RunLoop.Text = "button1";
            this.btn_RunLoop.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2251, 1921);
            this.Controls.Add(this.btn_RunLoop);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_RunLoop;
        private System.Windows.Forms.Timer timer1_Loop;
    }
}