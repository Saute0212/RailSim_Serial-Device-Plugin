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
            this.ConfirmConnection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ComSpeedList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM番号";
            // 
            // ComPorts
            // 
            this.ComPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComPorts.FormattingEnabled = true;
            this.ComPorts.Location = new System.Drawing.Point(82, 22);
            this.ComPorts.Margin = new System.Windows.Forms.Padding(2);
            this.ComPorts.Name = "ComPorts";
            this.ComPorts.Size = new System.Drawing.Size(92, 20);
            this.ComPorts.TabIndex = 1;
            // 
            // Reloading
            // 
            this.Reloading.Location = new System.Drawing.Point(194, 21);
            this.Reloading.Margin = new System.Windows.Forms.Padding(2);
            this.Reloading.Name = "Reloading";
            this.Reloading.Size = new System.Drawing.Size(56, 18);
            this.Reloading.TabIndex = 2;
            this.Reloading.Text = "更新";
            this.Reloading.UseVisualStyleBackColor = true;
            this.Reloading.Click += new System.EventHandler(this.Reloading_Click);
            // 
            // ConfirmConnection
            // 
            this.ConfirmConnection.Location = new System.Drawing.Point(282, 20);
            this.ConfirmConnection.Name = "ConfirmConnection";
            this.ConfirmConnection.Size = new System.Drawing.Size(75, 23);
            this.ConfirmConnection.TabIndex = 3;
            this.ConfirmConnection.Text = "接続確認";
            this.ConfirmConnection.UseVisualStyleBackColor = true;
            this.ConfirmConnection.Click += new System.EventHandler(this.ConfirmConnection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(510, 392);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 5;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(645, 391);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "通信速度";
            // 
            // ComSpeedList
            // 
            this.ComSpeedList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComSpeedList.FormattingEnabled = true;
            this.ComSpeedList.Location = new System.Drawing.Point(82, 69);
            this.ComSpeedList.Name = "ComSpeedList";
            this.ComSpeedList.Size = new System.Drawing.Size(121, 20);
            this.ComSpeedList.TabIndex = 8;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComSpeedList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConfirmConnection);
            this.Controls.Add(this.Reloading);
            this.Controls.Add(this.ComPorts);
            this.Controls.Add(this.label1);
            this.Name = "FormConfig";
            this.Text = "Serial Device Plugin Settings -v1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComPorts;
        private System.Windows.Forms.Button Reloading;
        private System.Windows.Forms.Button ConfirmConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComSpeedList;
    }
}