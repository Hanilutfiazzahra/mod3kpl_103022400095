namespace mod03_103022400095
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
            satuanAwal = new ComboBox();
            satuanAkhir = new ComboBox();
            nilaiAwal = new TextBox();
            nilaiAkhir = new TextBox();
            convert = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // satuanAwal
            // 
            satuanAwal.FormattingEnabled = true;
            satuanAwal.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Reamur", "Kelvin" });
            satuanAwal.Location = new Point(103, 65);
            satuanAwal.Name = "satuanAwal";
            satuanAwal.Size = new Size(141, 28);
            satuanAwal.TabIndex = 0;
            satuanAwal.Click += Form1_Load;
            // 
            // satuanAkhir
            // 
            satuanAkhir.FormattingEnabled = true;
            satuanAkhir.Location = new Point(103, 161);
            satuanAkhir.Name = "satuanAkhir";
            satuanAkhir.Size = new Size(141, 28);
            satuanAkhir.TabIndex = 1;
            satuanAkhir.Click += Form1_Load;
            // 
            // nilaiAwal
            // 
            nilaiAwal.Location = new Point(329, 65);
            nilaiAwal.Name = "nilaiAwal";
            nilaiAwal.Size = new Size(249, 27);
            nilaiAwal.TabIndex = 2;
            // 
            // nilaiAkhir
            // 
            nilaiAkhir.Location = new Point(329, 162);
            nilaiAkhir.Name = "nilaiAkhir";
            nilaiAkhir.Size = new Size(249, 27);
            nilaiAkhir.TabIndex = 3;
            // 
            // convert
            // 
            convert.Location = new Point(645, 65);
            convert.Name = "convert";
            convert.Size = new Size(94, 29);
            convert.TabIndex = 4;
            convert.Text = "Convert";
            convert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 42);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 5;
            label1.Text = "Nilai Awal";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 139);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 6;
            label2.Text = "Nilai Akhir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 42);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 7;
            label3.Text = "Satuan Awal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 138);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 8;
            label4.Text = "Satuan Akhir";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(convert);
            Controls.Add(nilaiAkhir);
            Controls.Add(nilaiAwal);
            Controls.Add(satuanAkhir);
            Controls.Add(satuanAwal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox satuanAwal;
        private ComboBox satuanAkhir;
        private TextBox nilaiAwal;
        private TextBox nilaiAkhir;
        private Button convert;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
