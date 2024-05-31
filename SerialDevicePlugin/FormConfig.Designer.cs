namespace SerialDevicePlugin
{
    partial class FormConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.ComPorts = new System.Windows.Forms.ComboBox();
            this.Reloading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM番号";
            // 
            // ComPorts
            // 
            this.ComPorts.FormattingEnabled = true;
            this.ComPorts.Location = new System.Drawing.Point(110, 27);
            this.ComPorts.Name = "ComPorts";
            this.ComPorts.Size = new System.Drawing.Size(121, 23);
            this.ComPorts.TabIndex = 1;
            // 
            // Reloading
            // 
            this.Reloading.Location = new System.Drawing.Point(259, 26);
            this.Reloading.Name = "Reloading";
            this.Reloading.Size = new System.Drawing.Size(75, 23);
            this.Reloading.TabIndex = 2;
            this.Reloading.Text = "更新";
            this.Reloading.UseVisualStyleBackColor = true;
            this.Reloading.Click += new System.EventHandler(this.Reloading_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.Reloading);
            this.Controls.Add(this.ComPorts);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConfig";
            this.Text = "Serial Device Plugin Settings -v1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComPorts;
        private System.Windows.Forms.Button Reloading;
    }
}