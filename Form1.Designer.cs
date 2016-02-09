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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fcve_chart_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fcve_chart_height)).BeginInit();
            this.SuspendLayout();
            // 
            // wb_fcve_chart
            // 
            this.wb_fcve_chart.Location = new System.Drawing.Point(457, 66);
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
            this.label5.Location = new System.Drawing.Point(21, 302);
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
            this.groupBox1.Location = new System.Drawing.Point(23, 322);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 86);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(29, 50);
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
            this.radioButton2.Location = new System.Drawing.Point(148, 50);
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
            this.label3.Location = new System.Drawing.Point(16, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chart Type *";
            // 
            // cb_fcve_chart_type
            // 
            this.cb_fcve_chart_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_fcve_chart_type.FormattingEnabled = true;
            this.cb_fcve_chart_type.Location = new System.Drawing.Point(21, 180);
            this.cb_fcve_chart_type.Name = "cb_fcve_chart_type";
            this.cb_fcve_chart_type.Size = new System.Drawing.Size(427, 24);
            this.cb_fcve_chart_type.TabIndex = 15;
            this.cb_fcve_chart_type.SelectionChangeCommitted += new System.EventHandler(this.cb_fcve_chart_type_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(23, 657);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1032, 170);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attributes ( Select chart to see them )";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(84, 47);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(637, 100);
            this.textBox3.TabIndex = 0;
            // 
            // txt_fcve_json_data
            // 
            this.txt_fcve_json_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fcve_json_data.Location = new System.Drawing.Point(21, 446);
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
            this.txt_fcve_xml_data.Location = new System.Drawing.Point(582, 442);
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
            this.label4.Location = new System.Drawing.Point(526, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(512, 538);
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
            this.label7.Location = new System.Drawing.Point(516, 569);
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
            this.label8.Location = new System.Drawing.Point(22, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Width ( % )";
            // 
            // tb_fcve_chart_width
            // 
            this.tb_fcve_chart_width.Location = new System.Drawing.Point(110, 223);
            this.tb_fcve_chart_width.Maximum = 100;
            this.tb_fcve_chart_width.Name = "tb_fcve_chart_width";
            this.tb_fcve_chart_width.Size = new System.Drawing.Size(301, 45);
            this.tb_fcve_chart_width.TabIndex = 24;
            this.tb_fcve_chart_width.Value = 20;
            this.tb_fcve_chart_width.Scroll += new System.EventHandler(this.tb_fcve_chart_width_Scroll);
            this.tb_fcve_chart_width.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tb_fcve_chart_width_MouseUp);
            // 
            // tb_fcve_chart_height
            // 
            this.tb_fcve_chart_height.Location = new System.Drawing.Point(110, 257);
            this.tb_fcve_chart_height.Maximum = 100;
            this.tb_fcve_chart_height.Name = "tb_fcve_chart_height";
            this.tb_fcve_chart_height.Size = new System.Drawing.Size(301, 45);
            this.tb_fcve_chart_height.TabIndex = 26;
            this.tb_fcve_chart_height.Value = 20;
            this.tb_fcve_chart_height.Scroll += new System.EventHandler(this.tb_fcve_chart_height_Scroll);
            this.tb_fcve_chart_height.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tb_fcve_chart_height_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Height ( % )";
            // 
            // txt_fcve_chart_width
            // 
            this.txt_fcve_chart_width.Location = new System.Drawing.Point(411, 223);
            this.txt_fcve_chart_width.Name = "txt_fcve_chart_width";
            this.txt_fcve_chart_width.ReadOnly = true;
            this.txt_fcve_chart_width.Size = new System.Drawing.Size(39, 20);
            this.txt_fcve_chart_width.TabIndex = 27;
            this.txt_fcve_chart_width.Text = "20%";
            // 
            // txt_fcve_chart_height
            // 
            this.txt_fcve_chart_height.Location = new System.Drawing.Point(411, 259);
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
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Chart Caption *";
            // 
            // txt_fcve_chart_caption
            // 
            this.txt_fcve_chart_caption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fcve_chart_caption.Location = new System.Drawing.Point(21, 66);
            this.txt_fcve_chart_caption.Name = "txt_fcve_chart_caption";
            this.txt_fcve_chart_caption.Size = new System.Drawing.Size(429, 23);
            this.txt_fcve_chart_caption.TabIndex = 4;
            this.txt_fcve_chart_caption.TextChanged += new System.EventHandler(this.txt_fcve_chart_caption_TextChanged);
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
            this.txt_fcve_chart_sub_caption.Location = new System.Drawing.Point(19, 124);
            this.txt_fcve_chart_sub_caption.Name = "txt_fcve_chart_sub_caption";
            this.txt_fcve_chart_sub_caption.Size = new System.Drawing.Size(429, 23);
            this.txt_fcve_chart_sub_caption.TabIndex = 29;
            // 
            // form_fcve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 836);
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
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fcve_chart_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fcve_chart_height)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fcve_chart_caption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fcve_chart_sub_caption;
    }
}

