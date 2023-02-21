
namespace WindowsFormsArduinoSerial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelVoltage = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.buttonGetPorts = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelVoltage
            // 
            this.labelVoltage.AutoSize = true;
            this.labelVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVoltage.Location = new System.Drawing.Point(46, 264);
            this.labelVoltage.Name = "labelVoltage";
            this.labelVoltage.Size = new System.Drawing.Size(231, 108);
            this.labelVoltage.TabIndex = 0;
            this.labelVoltage.Tag = "labVolt";
            this.labelVoltage.Text = "0.00";
            this.labelVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(235, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Open port";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // serialPort
            // 
            this.serialPort.PortName = "n";
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // buttonGetPorts
            // 
            this.buttonGetPorts.Location = new System.Drawing.Point(12, 12);
            this.buttonGetPorts.Name = "buttonGetPorts";
            this.buttonGetPorts.Size = new System.Drawing.Size(90, 23);
            this.buttonGetPorts.TabIndex = 2;
            this.buttonGetPorts.Text = "Get ports";
            this.buttonGetPorts.UseVisualStyleBackColor = true;
            this.buttonGetPorts.Click += new System.EventHandler(this.buttonGetPorts_Click);
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(108, 12);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 23);
            this.comboBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 441);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.buttonGetPorts);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.labelVoltage);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 480);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(340, 480);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ArduinoSerialVoltage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelVoltage;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonGetPorts;
        private System.Windows.Forms.ComboBox comboBox;
        public System.IO.Ports.SerialPort serialPort;
    }
}

