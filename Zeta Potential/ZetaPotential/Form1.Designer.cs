
namespace ZetaPotential
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PHValue = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColorValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TemperatureValue = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ZetaValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.ConductivityValue = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.TurbidityValue = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelConnection = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBaudrates = new System.Windows.Forms.ComboBox();
            this.comboBoxPortList = new System.Windows.Forms.ComboBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxSampleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxUpdateColor = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelControl.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PH";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.PHValue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 125);
            this.panel1.TabIndex = 1;
            // 
            // PHValue
            // 
            this.PHValue.AutoSize = true;
            this.PHValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHValue.ForeColor = System.Drawing.Color.Cornsilk;
            this.PHValue.Location = new System.Drawing.Point(10, 50);
            this.PHValue.Name = "PHValue";
            this.PHValue.Size = new System.Drawing.Size(42, 46);
            this.PHValue.TabIndex = 1;
            this.PHValue.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.ColorValue);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(347, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 125);
            this.panel2.TabIndex = 3;
            // 
            // ColorValue
            // 
            this.ColorValue.AutoSize = true;
            this.ColorValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorValue.ForeColor = System.Drawing.Color.Cornsilk;
            this.ColorValue.Location = new System.Drawing.Point(10, 50);
            this.ColorValue.Name = "ColorValue";
            this.ColorValue.Size = new System.Drawing.Size(42, 46);
            this.ColorValue.TabIndex = 1;
            this.ColorValue.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Color (RGB)";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TemperatureValue);
            this.panel3.Controls.Add(this.TemperatureLabel);
            this.panel3.Location = new System.Drawing.Point(662, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 125);
            this.panel3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(176, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "°C";
            // 
            // TemperatureValue
            // 
            this.TemperatureValue.AutoSize = true;
            this.TemperatureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureValue.ForeColor = System.Drawing.Color.Cornsilk;
            this.TemperatureValue.Location = new System.Drawing.Point(10, 50);
            this.TemperatureValue.Name = "TemperatureValue";
            this.TemperatureValue.Size = new System.Drawing.Size(42, 46);
            this.TemperatureValue.TabIndex = 1;
            this.TemperatureValue.Text = "0";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.TemperatureLabel.Location = new System.Drawing.Point(12, 10);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(169, 31);
            this.TemperatureLabel.TabIndex = 0;
            this.TemperatureLabel.Text = "Temperature";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.ZetaValue);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(662, 209);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 125);
            this.panel4.TabIndex = 7;
            // 
            // ZetaValue
            // 
            this.ZetaValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ZetaValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZetaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZetaValue.ForeColor = System.Drawing.Color.Cornsilk;
            this.ZetaValue.Location = new System.Drawing.Point(18, 47);
            this.ZetaValue.Name = "ZetaValue";
            this.ZetaValue.Size = new System.Drawing.Size(100, 53);
            this.ZetaValue.TabIndex = 3;
            this.ZetaValue.Text = "0";
            this.ZetaValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZetaValue_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cornsilk;
            this.label9.Location = new System.Drawing.Point(140, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "mV";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Cornsilk;
            this.label11.Location = new System.Drawing.Point(12, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "Zeta Potential";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.ConductivityValue);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(347, 209);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 125);
            this.panel5.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Cornsilk;
            this.label12.Location = new System.Drawing.Point(154, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 31);
            this.label12.TabIndex = 2;
            this.label12.Text = "uS/cm";
            // 
            // ConductivityValue
            // 
            this.ConductivityValue.AutoSize = true;
            this.ConductivityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConductivityValue.ForeColor = System.Drawing.Color.Cornsilk;
            this.ConductivityValue.Location = new System.Drawing.Point(10, 50);
            this.ConductivityValue.Name = "ConductivityValue";
            this.ConductivityValue.Size = new System.Drawing.Size(42, 46);
            this.ConductivityValue.TabIndex = 1;
            this.ConductivityValue.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Cornsilk;
            this.label14.Location = new System.Drawing.Point(12, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 31);
            this.label14.TabIndex = 0;
            this.label14.Text = "Conductivity";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.TurbidityValue);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Location = new System.Drawing.Point(33, 209);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(253, 125);
            this.panel6.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Cornsilk;
            this.label15.Location = new System.Drawing.Point(176, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 31);
            this.label15.TabIndex = 2;
            this.label15.Text = "NTU";
            // 
            // TurbidityValue
            // 
            this.TurbidityValue.AutoSize = true;
            this.TurbidityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurbidityValue.ForeColor = System.Drawing.Color.Cornsilk;
            this.TurbidityValue.Location = new System.Drawing.Point(10, 50);
            this.TurbidityValue.Name = "TurbidityValue";
            this.TurbidityValue.Size = new System.Drawing.Size(42, 46);
            this.TurbidityValue.TabIndex = 1;
            this.TurbidityValue.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Cornsilk;
            this.label17.Location = new System.Drawing.Point(12, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 31);
            this.label17.TabIndex = 0;
            this.label17.Text = "Turbidity";
            // 
            // panelConnection
            // 
            this.panelConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelConnection.Controls.Add(this.label3);
            this.panelConnection.Controls.Add(this.label2);
            this.panelConnection.Controls.Add(this.comboBoxBaudrates);
            this.panelConnection.Controls.Add(this.comboBoxPortList);
            this.panelConnection.Controls.Add(this.buttonDisconnect);
            this.panelConnection.Controls.Add(this.buttonConnect);
            this.panelConnection.Location = new System.Drawing.Point(12, 359);
            this.panelConnection.Name = "panelConnection";
            this.panelConnection.Size = new System.Drawing.Size(211, 106);
            this.panelConnection.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(100, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Baudrates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(9, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // comboBoxBaudrates
            // 
            this.comboBoxBaudrates.FormattingEnabled = true;
            this.comboBoxBaudrates.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBaudrates.Location = new System.Drawing.Point(105, 36);
            this.comboBoxBaudrates.Name = "comboBoxBaudrates";
            this.comboBoxBaudrates.Size = new System.Drawing.Size(89, 21);
            this.comboBoxBaudrates.TabIndex = 9;
            this.comboBoxBaudrates.Text = "9600";
            // 
            // comboBoxPortList
            // 
            this.comboBoxPortList.FormattingEnabled = true;
            this.comboBoxPortList.Location = new System.Drawing.Point(10, 36);
            this.comboBoxPortList.Name = "comboBoxPortList";
            this.comboBoxPortList.Size = new System.Drawing.Size(89, 21);
            this.comboBoxPortList.TabIndex = 8;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.buttonDisconnect.FlatAppearance.BorderSize = 2;
            this.buttonDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDisconnect.Location = new System.Drawing.Point(96, 63);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(112, 39);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.buttonConnect.FlatAppearance.BorderSize = 2;
            this.buttonConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConnect.Location = new System.Drawing.Point(3, 63);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(87, 39);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(229, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(729, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 30;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSave.Location = new System.Drawing.Point(92, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(258, 36);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.buttonClear.FlatAppearance.BorderSize = 2;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClear.Location = new System.Drawing.Point(242, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(258, 36);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.buttonAdd.FlatAppearance.BorderSize = 2;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(392, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(258, 36);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelControl
            // 
            this.panelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl.Controls.Add(this.buttonAdd);
            this.panelControl.Controls.Add(this.buttonSave);
            this.panelControl.Controls.Add(this.buttonClear);
            this.panelControl.Enabled = false;
            this.panelControl.Location = new System.Drawing.Point(229, 515);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(729, 42);
            this.panelControl.TabIndex = 13;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.checkBoxUpdateColor);
            this.panel7.Controls.Add(this.textBoxSampleName);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Location = new System.Drawing.Point(12, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(946, 345);
            this.panel7.TabIndex = 14;
            // 
            // textBoxSampleName
            // 
            this.textBoxSampleName.BackColor = System.Drawing.Color.DarkCyan;
            this.textBoxSampleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSampleName.ForeColor = System.Drawing.Color.Cornsilk;
            this.textBoxSampleName.Location = new System.Drawing.Point(218, 13);
            this.textBoxSampleName.Name = "textBoxSampleName";
            this.textBoxSampleName.Size = new System.Drawing.Size(166, 38);
            this.textBoxSampleName.TabIndex = 5;
            this.textBoxSampleName.Text = "Sample 1";
            this.textBoxSampleName.Click += new System.EventHandler(this.textBoxSampleName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(29, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sample Name";
            // 
            // checkBoxUpdateColor
            // 
            this.checkBoxUpdateColor.AutoSize = true;
            this.checkBoxUpdateColor.Checked = true;
            this.checkBoxUpdateColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUpdateColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUpdateColor.Location = new System.Drawing.Point(419, 34);
            this.checkBoxUpdateColor.Name = "checkBoxUpdateColor";
            this.checkBoxUpdateColor.Size = new System.Drawing.Size(134, 24);
            this.checkBoxUpdateColor.TabIndex = 15;
            this.checkBoxUpdateColor.Text = "Update Color";
            this.checkBoxUpdateColor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(978, 567);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelConnection);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Zeta Potential";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelConnection.ResumeLayout(false);
            this.panelConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PHValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ColorValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TemperatureValue;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ZetaValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ConductivityValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label TurbidityValue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelConnection;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBaudrates;
        private System.Windows.Forms.ComboBox comboBoxPortList;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelControl;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox textBoxSampleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxUpdateColor;
    }
}

