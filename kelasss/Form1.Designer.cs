namespace kelasss
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label8 = new Label();
            button1 = new Button();
            tb_nama = new TextBox();
            tb_jns_kelamin = new TextBox();
            tb_tmpt_lahir = new TextBox();
            tb_alamat = new TextBox();
            tb_kelas = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            tb_search = new TextBox();
            label6 = new Label();
            tb_id = new TextBox();
            label7 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 387);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(698, 177);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(label8);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 117);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(11, 36);
            label8.Name = "label8";
            label8.Size = new Size(187, 50);
            label8.TabIndex = 0;
            label8.Text = "HarfiMart";
            // 
            // button1
            // 
            button1.Location = new Point(506, 357);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "tambah";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tb_nama
            // 
            tb_nama.Location = new Point(103, 146);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(259, 23);
            tb_nama.TabIndex = 2;
            // 
            // tb_jns_kelamin
            // 
            tb_jns_kelamin.Location = new Point(103, 175);
            tb_jns_kelamin.Name = "tb_jns_kelamin";
            tb_jns_kelamin.Size = new Size(259, 23);
            tb_jns_kelamin.TabIndex = 3;
            // 
            // tb_tmpt_lahir
            // 
            tb_tmpt_lahir.Location = new Point(103, 204);
            tb_tmpt_lahir.Name = "tb_tmpt_lahir";
            tb_tmpt_lahir.Size = new Size(259, 23);
            tb_tmpt_lahir.TabIndex = 4;
            // 
            // tb_alamat
            // 
            tb_alamat.Location = new Point(103, 233);
            tb_alamat.Name = "tb_alamat";
            tb_alamat.Size = new Size(259, 23);
            tb_alamat.TabIndex = 5;
            // 
            // tb_kelas
            // 
            tb_kelas.Location = new Point(103, 262);
            tb_kelas.Name = "tb_kelas";
            tb_kelas.Size = new Size(259, 23);
            tb_kelas.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 149);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 7;
            label1.Text = "Kode Baju :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 178);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 8;
            label2.Text = "Merek Baju :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 207);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Tipe Baju :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 236);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 10;
            label4.Text = "Ukuran :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 265);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 11;
            label5.Text = "Harga :";
            // 
            // button2
            // 
            button2.Location = new Point(587, 357);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tb_search
            // 
            tb_search.Location = new Point(94, 357);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(346, 23);
            tb_search.TabIndex = 13;
            tb_search.TextChanged += tb_search_TextChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 360);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 14;
            label6.Text = "Cari";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(103, 291);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(259, 23);
            tb_id.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 294);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 16;
            label7.Text = "id :";
            // 
            // button3
            // 
            button3.Location = new Point(668, 358);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 17;
            button3.Text = "hapus";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(762, 586);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(tb_id);
            Controls.Add(label6);
            Controls.Add(tb_search);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_kelas);
            Controls.Add(tb_alamat);
            Controls.Add(tb_tmpt_lahir);
            Controls.Add(tb_jns_kelamin);
            Controls.Add(tb_nama);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button1;
        private TextBox tb_nama;
        private TextBox tb_jns_kelamin;
        private TextBox tb_tmpt_lahir;
        private TextBox tb_alamat;
        private TextBox tb_kelas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private TextBox tb_search;
        private Label label6;
        private TextBox tb_id;
        private Label label7;
        private Button button3;
        private Label label8;
    }
}