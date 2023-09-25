//using System;
//using System.Windows.Forms;

//namespace buoi2
//{
//    partial class Form1
//    {

//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        { }
//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        #region Windows Form Desiger generated code
//        private void InitializeComponent()
//        {
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.checkBox1 = new System.Windows.Forms.CheckBox();
//            this.radioButton1 = new System.Windows.Forms.RadioButton();
//            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
//            this.textBox1 = new System.Windows.Forms.TextBox();
//            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
//            this.bt_OK = new System.Windows.Forms.Button();
//            this.button2 = new System.Windows.Forms.Button();
//            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
//            this.comboBox1 = new System.Windows.Forms.ComboBox();
//            this.listBox1 = new System.Windows.Forms.ListBox();
//            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(54, 33);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(35, 13);
//            this.label1.TabIndex = 0;
//            this.label1.Text = "Name";
//            this.label1.Click += new System.EventHandler(this.label1_Click);
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(236, 204);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(0, 13);
//            this.label2.TabIndex = 1;
//            this.label2.Click += new System.EventHandler(this.label2_Click);
//            // 
//            // checkBox1
//            // 
//            this.checkBox1.AutoSize = true;
//            this.checkBox1.Location = new System.Drawing.Point(57, 82);
//            this.checkBox1.Name = "checkBox1";
//            this.checkBox1.Size = new System.Drawing.Size(80, 17);
//            this.checkBox1.TabIndex = 2;
//            this.checkBox1.Text = "checkBox1";
//            this.checkBox1.UseVisualStyleBackColor = true;
//            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
//            // 
//            // radioButton1
//            // 
//            this.radioButton1.AutoSize = true;
//            this.radioButton1.Location = new System.Drawing.Point(193, 82);
//            this.radioButton1.Name = "radioButton1";
//            this.radioButton1.Size = new System.Drawing.Size(85, 17);
//            this.radioButton1.TabIndex = 4;
//            this.radioButton1.TabStop = true;
//            this.radioButton1.Text = "radioButton1";
//            this.radioButton1.UseVisualStyleBackColor = true;
//            // 
//            // dateTimePicker1
//            // 
//            this.dateTimePicker1.Location = new System.Drawing.Point(57, 159);
//            this.dateTimePicker1.Name = "dateTimePicker1";
//            this.dateTimePicker1.Size = new System.Drawing.Size(260, 20);
//            this.dateTimePicker1.TabIndex = 5;
//            // 
//            // textBox1
//            // 
//            this.textBox1.Location = new System.Drawing.Point(124, 33);
//            this.textBox1.Name = "textBox1";
//            this.textBox1.Size = new System.Drawing.Size(202, 20);
//            this.textBox1.TabIndex = 6;
//            this.textBox1.Text = "Huynh Phuc Tan";
//            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
//            // 
//            // numericUpDown1
//            // 
//            this.numericUpDown1.Location = new System.Drawing.Point(369, 34);
//            this.numericUpDown1.Name = "numericUpDown1";
//            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
//            this.numericUpDown1.TabIndex = 7;
//            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
//            // 
//            // bt_OK
//            // 
//            this.bt_OK.Location = new System.Drawing.Point(388, 329);
//            this.bt_OK.Name = "bt_OK";
//            this.bt_OK.Size = new System.Drawing.Size(75, 23);
//            this.bt_OK.TabIndex = 8;
//            this.bt_OK.Text = "Cancel";
//            this.bt_OK.UseVisualStyleBackColor = true;
//            // 
//            // button2
//            // 
//            this.button2.Location = new System.Drawing.Point(484, 329);
//            this.button2.Name = "button2";
//            this.button2.Size = new System.Drawing.Size(75, 23);
//            this.button2.TabIndex = 9;
//            this.button2.Text = "OK\r\n";
//            this.button2.UseVisualStyleBackColor = true;
//            // 
//            // openFileDialog1
//            // 
//            this.openFileDialog1.FileName = "openFileDialog1";
//            // 
//            // comboBox1
//            // 
//            this.comboBox1.FormattingEnabled = true;
//            this.comboBox1.Location = new System.Drawing.Point(57, 120);
//            this.comboBox1.Name = "comboBox1";
//            this.comboBox1.Size = new System.Drawing.Size(260, 21);
//            this.comboBox1.TabIndex = 10;
//            // 
//            // listBox1
//            // 
//            this.listBox1.FormattingEnabled = true;
//            this.listBox1.Items.AddRange(new object[] {
//            "A",
//            "B",
//            "C",
//            "D",
//            "E",
//            "F",
//            "G",
//            "H"});
//            this.listBox1.Location = new System.Drawing.Point(57, 204);
//            this.listBox1.Name = "listBox1";
//            this.listBox1.Size = new System.Drawing.Size(200, 95);
//            this.listBox1.TabIndex = 11;
//            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
//            // 
//            // Form1
//            // 
//            this.ClientSize = new System.Drawing.Size(586, 372);
//            this.Controls.Add(this.listBox1);
//            this.Controls.Add(this.comboBox1);
//            this.Controls.Add(this.button2);
//            this.Controls.Add(this.bt_OK);
//            this.Controls.Add(this.numericUpDown1);
//            this.Controls.Add(this.textBox1);
//            this.Controls.Add(this.dateTimePicker1);
//            this.Controls.Add(this.radioButton1);
//            this.Controls.Add(this.checkBox1);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.label1);
//            this.KeyPreview = true;
//            this.Name = "Form1";
//            this.ShowInTaskbar = false;
//            this.Text = "From1";
//            this.Load += new System.EventHandler(this.Form1_Load);
//            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
//            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        private void Form1_KeyUp(object sender, KeyEventArgs e)
//        {
//            throw new NotImplementedException();
//        }

//        #endregion

//        private Label label1;
//        private Label label2;
//        private CheckBox checkBox1;
//        private RadioButton radioButton1;
//        private DateTimePicker dateTimePicker1;
//        private TextBox textBox1;
//        private NumericUpDown numericUpDown1;
//        private Button bt_OK;
//        private Button button2;
//        private OpenFileDialog openFileDialog1;
//        private ComboBox comboBox1;
//        private ListBox listBox1;
//    }
//}

