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
            this.labelHEXValue = new System.Windows.Forms.Label();
            this.labelRedValue = new System.Windows.Forms.Label();
            this.labelGreenValue = new System.Windows.Forms.Label();
            this.labelBlueValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonModeNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonModeBreath = new System.Windows.Forms.RadioButton();
            this.radioButtonModeStiobe = new System.Windows.Forms.RadioButton();
            this.radioButtonModeRainbow = new System.Windows.Forms.RadioButton();
            this.radioButtonBRainbow = new System.Windows.Forms.RadioButton();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarModeSpeed = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.labelModeSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorWheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarModeSpeed)).BeginInit();
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
            this.pictureBoxSelectedColor.Location = new System.Drawing.Point(341, 42);
            this.pictureBoxSelectedColor.Name = "pictureBoxSelectedColor";
            this.pictureBoxSelectedColor.Size = new System.Drawing.Size(47, 50);
            this.pictureBoxSelectedColor.TabIndex = 1;
            this.pictureBoxSelectedColor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Blue";
            // 
            // labelHEXValue
            // 
            this.labelHEXValue.AutoSize = true;
            this.labelHEXValue.Location = new System.Drawing.Point(467, 13);
            this.labelHEXValue.Name = "labelHEXValue";
            this.labelHEXValue.Size = new System.Drawing.Size(13, 13);
            this.labelHEXValue.TabIndex = 2;
            this.labelHEXValue.Text = "0";
            // 
            // labelRedValue
            // 
            this.labelRedValue.AutoSize = true;
            this.labelRedValue.Location = new System.Drawing.Point(467, 35);
            this.labelRedValue.Name = "labelRedValue";
            this.labelRedValue.Size = new System.Drawing.Size(13, 13);
            this.labelRedValue.TabIndex = 3;
            this.labelRedValue.Text = "0";
            // 
            // labelGreenValue
            // 
            this.labelGreenValue.AutoSize = true;
            this.labelGreenValue.Location = new System.Drawing.Point(467, 57);
            this.labelGreenValue.Name = "labelGreenValue";
            this.labelGreenValue.Size = new System.Drawing.Size(13, 13);
            this.labelGreenValue.TabIndex = 4;
            this.labelGreenValue.Text = "0";
            // 
            // labelBlueValue
            // 
            this.labelBlueValue.AutoSize = true;
            this.labelBlueValue.Location = new System.Drawing.Point(467, 79);
            this.labelBlueValue.Name = "labelBlueValue";
            this.labelBlueValue.Size = new System.Drawing.Size(13, 13);
            this.labelBlueValue.TabIndex = 5;
            this.labelBlueValue.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 13);
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
            // radioButtonModeNormal
            // 
            this.radioButtonModeNormal.AutoSize = true;
            this.radioButtonModeNormal.Checked = true;
            this.radioButtonModeNormal.Location = new System.Drawing.Point(341, 168);
            this.radioButtonModeNormal.Name = "radioButtonModeNormal";
            this.radioButtonModeNormal.Size = new System.Drawing.Size(58, 17);
            this.radioButtonModeNormal.TabIndex = 12;
            this.radioButtonModeNormal.TabStop = true;
            this.radioButtonModeNormal.Text = "Normal";
            this.radioButtonModeNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonModeBreath
            // 
            this.radioButtonModeBreath.AutoSize = true;
            this.radioButtonModeBreath.Location = new System.Drawing.Point(341, 191);
            this.radioButtonModeBreath.Name = "radioButtonModeBreath";
            this.radioButtonModeBreath.Size = new System.Drawing.Size(56, 17);
            this.radioButtonModeBreath.TabIndex = 13;
            this.radioButtonModeBreath.TabStop = true;
            this.radioButtonModeBreath.Text = "Breath";
            this.radioButtonModeBreath.UseVisualStyleBackColor = true;
            // 
            // radioButtonModeStiobe
            // 
            this.radioButtonModeStiobe.AutoSize = true;
            this.radioButtonModeStiobe.Location = new System.Drawing.Point(341, 214);
            this.radioButtonModeStiobe.Name = "radioButtonModeStiobe";
            this.radioButtonModeStiobe.Size = new System.Drawing.Size(56, 17);
            this.radioButtonModeStiobe.TabIndex = 14;
            this.radioButtonModeStiobe.TabStop = true;
            this.radioButtonModeStiobe.Text = "Strobe";
            this.radioButtonModeStiobe.UseVisualStyleBackColor = true;
            // 
            // radioButtonModeRainbow
            // 
            this.radioButtonModeRainbow.AutoSize = true;
            this.radioButtonModeRainbow.Location = new System.Drawing.Point(341, 238);
            this.radioButtonModeRainbow.Name = "radioButtonModeRainbow";
            this.radioButtonModeRainbow.Size = new System.Drawing.Size(67, 17);
            this.radioButtonModeRainbow.TabIndex = 15;
            this.radioButtonModeRainbow.TabStop = true;
            this.radioButtonModeRainbow.Text = "Rainbow";
            this.radioButtonModeRainbow.UseVisualStyleBackColor = true;
            // 
            // radioButtonBRainbow
            // 
            this.radioButtonBRainbow.AutoSize = true;
            this.radioButtonBRainbow.Location = new System.Drawing.Point(341, 262);
            this.radioButtonBRainbow.Name = "radioButtonBRainbow";
            this.radioButtonBRainbow.Size = new System.Drawing.Size(110, 17);
            this.radioButtonBRainbow.TabIndex = 16;
            this.radioButtonBRainbow.TabStop = true;
            this.radioButtonBRainbow.Text = "Breathing rainbow";
            this.radioButtonBRainbow.UseVisualStyleBackColor = true;
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(341, 123);
            this.trackBarBrightness.Maximum = 100;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(161, 45);
            this.trackBarBrightness.TabIndex = 17;
            this.trackBarBrightness.TickFrequency = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "LED Brightness %";
            // 
            // trackBarModeSpeed
            // 
            this.trackBarModeSpeed.Location = new System.Drawing.Point(341, 317);
            this.trackBarModeSpeed.Minimum = 1;
            this.trackBarModeSpeed.Name = "trackBarModeSpeed";
            this.trackBarModeSpeed.Size = new System.Drawing.Size(161, 45);
            this.trackBarModeSpeed.TabIndex = 19;
            this.trackBarModeSpeed.Value = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mode Speed";
            // 
            // labelBrightness
            // 
            this.labelBrightness.AutoSize = true;
            this.labelBrightness.Location = new System.Drawing.Point(467, 107);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.Size = new System.Drawing.Size(13, 13);
            this.labelBrightness.TabIndex = 21;
            this.labelBrightness.Text = "0";
            // 
            // labelModeSpeed
            // 
            this.labelModeSpeed.AutoSize = true;
            this.labelModeSpeed.Location = new System.Drawing.Point(416, 301);
            this.labelModeSpeed.Name = "labelModeSpeed";
            this.labelModeSpeed.Size = new System.Drawing.Size(13, 13);
            this.labelModeSpeed.TabIndex = 22;
            this.labelModeSpeed.Text = "1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(520, 358);
            this.Controls.Add(this.labelModeSpeed);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBarModeSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.radioButtonBRainbow);
            this.Controls.Add(this.radioButtonModeRainbow);
            this.Controls.Add(this.radioButtonModeStiobe);
            this.Controls.Add(this.radioButtonModeBreath);
            this.Controls.Add(this.radioButtonModeNormal);
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
            this.Controls.Add(this.labelHEXValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSelectedColor);
            this.Controls.Add(this.pictureBoxColorWheel);
            this.Name = "MainForm";
            this.Text = "ColorPicker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorWheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarModeSpeed)).EndInit();
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
        private System.Windows.Forms.Label labelHEXValue;
        private System.Windows.Forms.Label labelRedValue;
        private System.Windows.Forms.Label labelGreenValue;
        private System.Windows.Forms.Label labelBlueValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonModeNormal;
        private System.Windows.Forms.RadioButton radioButtonModeBreath;
        private System.Windows.Forms.RadioButton radioButtonModeStiobe;
        private System.Windows.Forms.RadioButton radioButtonModeRainbow;
        private System.Windows.Forms.RadioButton radioButtonBRainbow;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarModeSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.Label labelModeSpeed;
    }
}

