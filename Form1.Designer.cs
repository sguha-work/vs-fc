namespace fc_ve
{
    partial class form_fcve
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
            this.wb_fcve_chart = new System.Windows.Forms.WebBrowser();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_fcve_chart_type = new System.Windows.Forms.ComboBox();
            this.txt_fcve_json_data = new System.Windows.Forms.TextBox();
            this.txt_fcve_xml_data = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_fcve_chart_width = new System.Windows.Forms.TrackBar();
            this.tb_fcve_chart_height = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_fcve_chart_width = new System.Windows.Forms.TextBox();
            this.txt_fcve_chart_height = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fcve_chart_caption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fcve_chart_sub_caption = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_fcve_chart_xaxis_name = new System.Windows.Forms.TextBox();
            this.txt_fcve_chart_yaxis_name = new System.Windows.Forms.TextBox();
            this.dgv_fcve_chart_data = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_fcve_theme_carbon = new System.Windows.Forms.RadioButton();
            this.rb_fcve_theme_ocean = new System.Windows.Forms.RadioButton();
            this.rb_fcve_theme_zune = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.panel_fcve_events = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel_fcve_events_code = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fcve_chart_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fcve_chart_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fcve_chart_data)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wb_fcve_chart
            // 
            this.wb_fcve_chart.Location = new System.Drawing.Point(456, 66);
            this.wb_fcve_chart.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_fcve_chart.Name = "wb_fcve_chart";
            this.wb_fcve_chart.ScriptErrorsSuppressed = true;
            this.wb_fcve_chart.ScrollBarsEnabled = false;
            this.wb_fcve_chart.Size = new System.Drawing.Size(604, 370);
            this.wb_fcve_chart.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chart Data Type *";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(22, 353);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 55);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(225, 23);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "JSON URL";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(149, 23);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(54, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "XML";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(341, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "XML URL";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(29, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "JSON";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chart Type *";
            // 
            // cb_fcve_chart_type
            // 
            this.cb_fcve_chart_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_fcve_chart_type.FormattingEnabled = true;
            this.cb_fcve_chart_type.Location = new System.Drawing.Point(169, 136);
            this.cb_fcve_chart_type.Name = "cb_fcve_chart_type";
            this.cb_fcve_chart_type.Size = new System.Drawing.Size(279, 24);
            this.cb_fcve_chart_type.TabIndex = 15;
            this.cb_fcve_chart_type.SelectionChangeCommitted += new System.EventHandler(this.cb_fcve_chart_type_SelectionChangeCommitted);
            // 
            // txt_fcve_json_data
            // 
            this.txt_fcve_json_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fcve_json_data.Location = new System.Drawing.Point(19, 619);
            this.txt_fcve_json_data.Multiline = true;
            this.txt_fcve_json_data.Name = "txt_fcve_json_data";
            this.txt_fcve_json_data.ReadOnly = true;
            this.txt_fcve_json_data.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_fcve_json_data.Size = new System.Drawing.Size(484, 205);
            this.txt_fcve_json_data.TabIndex = 17;
            this.txt_fcve_json_data.WordWrap = false;
            this.txt_fcve_json_data.TextChanged += new System.EventHandler(this.txt_fcve_json_data_TextChanged);
            // 
            // txt_fcve_xml_data
            // 
            this.txt_fcve_xml_data.Location = new System.Drawing.Point(582, 619);
            this.txt_fcve_xml_data.Multiline = true;
            this.txt_fcve_xml_data.Name = "txt_fcve_xml_data";
            this.txt_fcve_xml_data.ReadOnly = true;
            this.txt_fcve_xml_data.Size = new System.Drawing.Size(475, 205);
            this.txt_fcve_xml_data.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Chart Object";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 701);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "< JSON";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(516, 732);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "XML >";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(22, 416);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(428, 20);
            this.textBox5.TabIndex = 22;
            this.textBox5.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Width ( % )";
            // 
            // tb_fcve_chart_width
            // 
            this.tb_fcve_chart_width.Location = new System.Drawing.Point(161, 174);
            this.tb_fcve_chart_width.Maximum = 100;
            this.tb_fcve_chart_width.Name = "tb_fcve_chart_width";
            this.tb_fcve_chart_width.Size = new System.Drawing.Size(250, 45);
            this.tb_fcve_chart_width.TabIndex = 24;
            this.tb_fcve_chart_width.Value = 20;
            this.tb_fcve_chart_width.Scroll += new System.EventHandler(this.tb_fcve_chart_width_Scroll);
            this.tb_fcve_chart_width.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tb_fcve_chart_width_MouseUp);
            // 
            // tb_fcve_chart_height
            // 
            this.tb_fcve_chart_height.Location = new System.Drawing.Point(161, 215);
            this.tb_fcve_chart_height.Maximum = 100;
            this.tb_fcve_chart_height.Name = "tb_fcve_chart_height";
            this.tb_fcve_chart_height.Size = new System.Drawing.Size(250, 45);
            this.tb_fcve_chart_height.TabIndex = 26;
            this.tb_fcve_chart_height.Value = 20;
            this.tb_fcve_chart_height.Scroll += new System.EventHandler(this.tb_fcve_chart_height_Scroll);
            this.tb_fcve_chart_height.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tb_fcve_chart_height_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Height ( % )";
            // 
            // txt_fcve_chart_width
            // 
            this.txt_fcve_chart_width.Location = new System.Drawing.Point(411, 174);
            this.txt_fcve_chart_width.Name = "txt_fcve_chart_width";
            this.txt_fcve_chart_width.ReadOnly = true;
            this.txt_fcve_chart_width.Size = new System.Drawing.Size(39, 20);
            this.txt_fcve_chart_width.TabIndex = 27;
            this.txt_fcve_chart_width.Text = "20%";
            // 
            // txt_fcve_chart_height
            // 
            this.txt_fcve_chart_height.Location = new System.Drawing.Point(411, 217);
            this.txt_fcve_chart_height.Name = "txt_fcve_chart_height";
            this.txt_fcve_chart_height.ReadOnly = true;
            this.txt_fcve_chart_height.Size = new System.Drawing.Size(39, 20);
            this.txt_fcve_chart_height.TabIndex = 28;
            this.txt_fcve_chart_height.Text = "20%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chart Caption *";
            // 
            // txt_fcve_chart_caption
            // 
            this.txt_fcve_chart_caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fcve_chart_caption.Location = new System.Drawing.Point(169, 66);
            this.txt_fcve_chart_caption.Name = "txt_fcve_chart_caption";
            this.txt_fcve_chart_caption.Size = new System.Drawing.Size(278, 23);
            this.txt_fcve_chart_caption.TabIndex = 4;
            this.txt_fcve_chart_caption.Enter += new System.EventHandler(this.txt_fcve_chart_caption_Enter);
            this.txt_fcve_chart_caption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fcve_chart_caption_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Chart Sub Caption *";
            // 
            // txt_fcve_chart_sub_caption
            // 
            this.txt_fcve_chart_sub_caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fcve_chart_sub_caption.Location = new System.Drawing.Point(169, 101);
            this.txt_fcve_chart_sub_caption.Name = "txt_fcve_chart_sub_caption";
            this.txt_fcve_chart_sub_caption.Size = new System.Drawing.Size(279, 23);
            this.txt_fcve_chart_sub_caption.TabIndex = 29;
            this.txt_fcve_chart_sub_caption.Enter += new System.EventHandler(this.txt_fcve_chart_sub_caption_Enter);
            this.txt_fcve_chart_sub_caption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fcve_chart_sub_caption_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "X Axis Name *";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Y Axis Name *";
            // 
            // txt_fcve_chart_xaxis_name
            // 
            this.txt_fcve_chart_xaxis_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fcve_chart_xaxis_name.Location = new System.Drawing.Point(169, 257);
            this.txt_fcve_chart_xaxis_name.Name = "txt_fcve_chart_xaxis_name";
            this.txt_fcve_chart_xaxis_name.Size = new System.Drawing.Size(278, 23);
            this.txt_fcve_chart_xaxis_name.TabIndex = 35;
            this.txt_fcve_chart_xaxis_name.Enter += new System.EventHandler(this.txt_fcve_chart_xaxis_name_Enter);
            this.txt_fcve_chart_xaxis_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fcve_chart_xaxis_name_KeyPress);
            // 
            // txt_fcve_chart_yaxis_name
            // 
            this.txt_fcve_chart_yaxis_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fcve_chart_yaxis_name.Location = new System.Drawing.Point(169, 295);
            this.txt_fcve_chart_yaxis_name.Name = "txt_fcve_chart_yaxis_name";
            this.txt_fcve_chart_yaxis_name.Size = new System.Drawing.Size(278, 23);
            this.txt_fcve_chart_yaxis_name.TabIndex = 36;
            this.txt_fcve_chart_yaxis_name.Enter += new System.EventHandler(this.txt_fcve_chart_yaxis_name_Enter);
            this.txt_fcve_chart_yaxis_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fcve_chart_yaxis_name_KeyPress);
            // 
            // dgv_fcve_chart_data
            // 
            this.dgv_fcve_chart_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fcve_chart_data.Location = new System.Drawing.Point(22, 472);
            this.dgv_fcve_chart_data.Name = "dgv_fcve_chart_data";
            this.dgv_fcve_chart_data.Size = new System.Drawing.Size(1034, 121);
            this.dgv_fcve_chart_data.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_fcve_theme_carbon);
            this.groupBox2.Controls.Add(this.rb_fcve_theme_ocean);
            this.groupBox2.Controls.Add(this.rb_fcve_theme_zune);
            this.groupBox2.Location = new System.Drawing.Point(626, 439);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(214, 23);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // rb_fcve_theme_carbon
            // 
            this.rb_fcve_theme_carbon.AutoSize = true;
            this.rb_fcve_theme_carbon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_fcve_theme_carbon.Location = new System.Drawing.Point(144, 3);
            this.rb_fcve_theme_carbon.Name = "rb_fcve_theme_carbon";
            this.rb_fcve_theme_carbon.Size = new System.Drawing.Size(72, 21);
            this.rb_fcve_theme_carbon.TabIndex = 3;
            this.rb_fcve_theme_carbon.TabStop = true;
            this.rb_fcve_theme_carbon.Text = "Carbon";
            this.rb_fcve_theme_carbon.UseVisualStyleBackColor = true;
            this.rb_fcve_theme_carbon.CheckedChanged += new System.EventHandler(this.rb_fcve_theme_carbon_CheckedChanged);
            // 
            // rb_fcve_theme_ocean
            // 
            this.rb_fcve_theme_ocean.AutoSize = true;
            this.rb_fcve_theme_ocean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_fcve_theme_ocean.Location = new System.Drawing.Point(70, 2);
            this.rb_fcve_theme_ocean.Name = "rb_fcve_theme_ocean";
            this.rb_fcve_theme_ocean.Size = new System.Drawing.Size(68, 21);
            this.rb_fcve_theme_ocean.TabIndex = 2;
            this.rb_fcve_theme_ocean.TabStop = true;
            this.rb_fcve_theme_ocean.Text = "Ocean";
            this.rb_fcve_theme_ocean.UseVisualStyleBackColor = true;
            this.rb_fcve_theme_ocean.CheckedChanged += new System.EventHandler(this.rb_fcve_theme_ocean_CheckedChanged);
            // 
            // rb_fcve_theme_zune
            // 
            this.rb_fcve_theme_zune.AutoSize = true;
            this.rb_fcve_theme_zune.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_fcve_theme_zune.Location = new System.Drawing.Point(4, 3);
            this.rb_fcve_theme_zune.Name = "rb_fcve_theme_zune";
            this.rb_fcve_theme_zune.Size = new System.Drawing.Size(59, 21);
            this.rb_fcve_theme_zune.TabIndex = 0;
            this.rb_fcve_theme_zune.TabStop = true;
            this.rb_fcve_theme_zune.Text = "Zune";
            this.rb_fcve_theme_zune.UseVisualStyleBackColor = true;
            this.rb_fcve_theme_zune.CheckedChanged += new System.EventHandler(this.rb_fcve_theme_zune_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(531, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 38;
            this.label12.Text = "Theme";
            // 
            // panel_fcve_events
            // 
            this.panel_fcve_events.AutoScroll = true;
            this.panel_fcve_events.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_fcve_events.Location = new System.Drawing.Point(1078, 86);
            this.panel_fcve_events.Name = "panel_fcve_events";
            this.panel_fcve_events.Size = new System.Drawing.Size(357, 335);
            this.panel_fcve_events.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1075, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(326, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "Events ( Check event name and write code below )";
            // 
            // panel_fcve_events_code
            // 
            this.panel_fcve_events_code.AutoScroll = true;
            this.panel_fcve_events_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_fcve_events_code.Location = new System.Drawing.Point(1078, 459);
            this.panel_fcve_events_code.Name = "panel_fcve_events_code";
            this.panel_fcve_events_code.Size = new System.Drawing.Size(357, 326);
            this.panel_fcve_events_code.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1075, 439);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(341, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "Here below the text box will apper to write event code";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1078, 791);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 32);
            this.button1.TabIndex = 42;
            this.button1.Text = "Click To Submit Selected Events";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // form_fcve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 836);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel_fcve_events_code);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel_fcve_events);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_fcve_chart_data);
            this.Controls.Add(this.txt_fcve_chart_yaxis_name);
            this.Controls.Add(this.txt_fcve_chart_xaxis_name);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fcve_chart_sub_caption);
            this.Controls.Add(this.txt_fcve_chart_height);
            this.Controls.Add(this.txt_fcve_json_data);
            this.Controls.Add(this.txt_fcve_chart_width);
            this.Controls.Add(this.tb_fcve_chart_height);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_fcve_chart_width);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_fcve_xml_data);
            this.Controls.Add(this.cb_fcve_chart_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fcve_chart_caption);
            this.Controls.Add(this.wb_fcve_chart);
            this.MaximizeBox = false;
            this.Name = "form_fcve";
            this.Text = "FusionCharts-VisualEditor";
            this.Load += new System.EventHandler(this.form_vbfc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fcve_chart_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fcve_chart_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fcve_chart_data)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb_fcve_chart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_fcve_chart_type;
        private System.Windows.Forms.TextBox txt_fcve_json_data;
        private System.Windows.Forms.TextBox txt_fcve_xml_data;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tb_fcve_chart_width;
        private System.Windows.Forms.TrackBar tb_fcve_chart_height;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_fcve_chart_width;
        private System.Windows.Forms.TextBox txt_fcve_chart_height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fcve_chart_caption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fcve_chart_sub_caption;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_fcve_chart_xaxis_name;
        private System.Windows.Forms.TextBox txt_fcve_chart_yaxis_name;
        private System.Windows.Forms.DataGridView dgv_fcve_chart_data;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_fcve_theme_carbon;
        private System.Windows.Forms.RadioButton rb_fcve_theme_ocean;
        private System.Windows.Forms.RadioButton rb_fcve_theme_zune;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel panel_fcve_events;
        public System.Windows.Forms.Panel panel_fcve_events_code;
    }
}

