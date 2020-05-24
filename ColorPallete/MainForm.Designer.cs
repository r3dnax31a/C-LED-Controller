namespace ColorPallete
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxColorWheel = new System.Windows.Forms.PictureBox();
            this.pictureBoxSelectedColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAlphaValue = new System.Windows.Forms.Label();
            this.labelRedValue = new System.Windows.Forms.Label();
            this.labelGreenValue = new System.Windows.Forms.Label();
            this.labelBlueValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedColor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxColorWheel
            // 
            this.pictureBoxColorWheel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxColorWheel.Image")));
            this.pictureBoxColorWheel.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxColorWheel.Name = "pictureBoxColorWheel";
            this.pictureBoxColorWheel.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxColorWheel.TabIndex = 0;
            this.pictureBoxColorWheel.TabStop = false;
            // 
            // pictureBoxSelectedColor
            // 
            this.pictureBoxSelectedColor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBoxSelectedColor.Location = new System.Drawing.Point(331, 42);
            this.pictureBoxSelectedColor.Name = "pictureBoxSelectedColor";
            this.pictureBoxSelectedColor.Size = new System.Drawing.Size(47, 50);
            this.pictureBoxSelectedColor.TabIndex = 1;
            this.pictureBoxSelectedColor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Blue";
            // 
            // labelAlphaValue
            // 
            this.labelAlphaValue.AutoSize = true;
            this.labelAlphaValue.Location = new System.Drawing.Point(453, 13);
            this.labelAlphaValue.Name = "labelAlphaValue";
            this.labelAlphaValue.Size = new System.Drawing.Size(13, 13);
            this.labelAlphaValue.TabIndex = 2;
            this.labelAlphaValue.Text = "0";
            // 
            // labelRedValue
            // 
            this.labelRedValue.AutoSize = true;
            this.labelRedValue.Location = new System.Drawing.Point(453, 35);
            this.labelRedValue.Name = "labelRedValue";
            this.labelRedValue.Size = new System.Drawing.Size(13, 13);
            this.labelRedValue.TabIndex = 3;
            this.labelRedValue.Text = "0";
            // 
            // labelGreenValue
            // 
            this.labelGreenValue.AutoSize = true;
            this.labelGreenValue.Location = new System.Drawing.Point(453, 57);
            this.labelGreenValue.Name = "labelGreenValue";
            this.labelGreenValue.Size = new System.Drawing.Size(13, 13);
            this.labelGreenValue.TabIndex = 4;
            this.labelGreenValue.Text = "0";
            // 
            // labelBlueValue
            // 
            this.labelBlueValue.AutoSize = true;
            this.labelBlueValue.Location = new System.Drawing.Point(453, 79);
            this.labelBlueValue.Name = "labelBlueValue";
            this.labelBlueValue.Size = new System.Drawing.Size(13, 13);
            this.labelBlueValue.TabIndex = 5;
            this.labelBlueValue.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "Selected \r\ncolor";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(238, 320);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 8;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(104, 322);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(128, 21);
            this.comboBoxPorts.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Select COM Port";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(520, 358);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelBlueValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelGreenValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRedValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAlphaValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSelectedColor);
            this.Controls.Add(this.pictureBoxColorWheel);
            this.Name = "MainForm";
            this.Text = "ColorPicker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxColorWheel;
        private System.Windows.Forms.PictureBox pictureBoxSelectedColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAlphaValue;
        private System.Windows.Forms.Label labelRedValue;
        private System.Windows.Forms.Label labelGreenValue;
        private System.Windows.Forms.Label labelBlueValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Label label6;
    }
}

