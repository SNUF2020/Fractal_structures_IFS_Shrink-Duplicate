namespace IFS_Shrink_Duplicate_V2._0
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Safe = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Load = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Info = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.textBox_IFSName = new System.Windows.Forms.TextBox();
            this.FractalName = new System.Windows.Forms.Label();
            this.groupBox_Fractal = new System.Windows.Forms.GroupBox();
            this.radioButton_ImportIFS = new System.Windows.Forms.RadioButton();
            this.radioButton_SirCarp = new System.Windows.Forms.RadioButton();
            this.radioButton_Vic = new System.Windows.Forms.RadioButton();
            this.radioButton_SirPenta = new System.Windows.Forms.RadioButton();
            this.radioButton_CantorLab = new System.Windows.Forms.RadioButton();
            this.radioButton_Koch = new System.Windows.Forms.RadioButton();
            this.radioButton_Sirpinski = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Points = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox_Fractal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 148);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(509, 200);
            this.dataGridView2.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Start,
            this.toolStripButton_Safe,
            this.toolStripButton_Load,
            this.toolStripButton_Info,
            this.toolStripButton_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(790, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Start
            // 
            this.toolStripButton_Start.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Start.Image")));
            this.toolStripButton_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Start.Name = "toolStripButton_Start";
            this.toolStripButton_Start.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton_Start.Text = "Start IFS";
            this.toolStripButton_Start.Click += new System.EventHandler(this.toolStripButton_Start_Click);
            // 
            // toolStripButton_Safe
            // 
            this.toolStripButton_Safe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Safe.Image")));
            this.toolStripButton_Safe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Safe.Name = "toolStripButton_Safe";
            this.toolStripButton_Safe.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton_Safe.Text = "Safe IFS";
            this.toolStripButton_Safe.Click += new System.EventHandler(this.toolStripButton_Safe_Click);
            // 
            // toolStripButton_Load
            // 
            this.toolStripButton_Load.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Load.Image")));
            this.toolStripButton_Load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Load.Name = "toolStripButton_Load";
            this.toolStripButton_Load.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton_Load.Text = "Load IFS";
            this.toolStripButton_Load.Click += new System.EventHandler(this.toolStripButton_Load_Click);
            // 
            // toolStripButton_Info
            // 
            this.toolStripButton_Info.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Info.Image")));
            this.toolStripButton_Info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Info.Name = "toolStripButton_Info";
            this.toolStripButton_Info.Size = new System.Drawing.Size(90, 22);
            this.toolStripButton_Info.Text = "Information";
            this.toolStripButton_Info.Click += new System.EventHandler(this.toolStripButton_Info_Click);
            // 
            // toolStripButton_Exit
            // 
            this.toolStripButton_Exit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Exit.Image")));
            this.toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Exit.Name = "toolStripButton_Exit";
            this.toolStripButton_Exit.Size = new System.Drawing.Size(95, 22);
            this.toolStripButton_Exit.Text = "Exit Program";
            this.toolStripButton_Exit.Click += new System.EventHandler(this.toolStripButton_Exit_Click);
            // 
            // textBox_IFSName
            // 
            this.textBox_IFSName.Location = new System.Drawing.Point(129, 57);
            this.textBox_IFSName.Name = "textBox_IFSName";
            this.textBox_IFSName.Size = new System.Drawing.Size(262, 20);
            this.textBox_IFSName.TabIndex = 21;
            this.textBox_IFSName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IFSName_KeyPress);
            // 
            // FractalName
            // 
            this.FractalName.AutoSize = true;
            this.FractalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FractalName.Location = new System.Drawing.Point(26, 53);
            this.FractalName.Name = "FractalName";
            this.FractalName.Size = new System.Drawing.Size(94, 24);
            this.FractalName.TabIndex = 20;
            this.FractalName.Text = "IFS Name";
            // 
            // groupBox_Fractal
            // 
            this.groupBox_Fractal.Controls.Add(this.radioButton_ImportIFS);
            this.groupBox_Fractal.Controls.Add(this.radioButton_SirCarp);
            this.groupBox_Fractal.Controls.Add(this.radioButton_Vic);
            this.groupBox_Fractal.Controls.Add(this.radioButton_SirPenta);
            this.groupBox_Fractal.Controls.Add(this.radioButton_CantorLab);
            this.groupBox_Fractal.Controls.Add(this.radioButton_Koch);
            this.groupBox_Fractal.Controls.Add(this.radioButton_Sirpinski);
            this.groupBox_Fractal.Location = new System.Drawing.Point(533, 30);
            this.groupBox_Fractal.Name = "groupBox_Fractal";
            this.groupBox_Fractal.Size = new System.Drawing.Size(248, 318);
            this.groupBox_Fractal.TabIndex = 22;
            this.groupBox_Fractal.TabStop = false;
            this.groupBox_Fractal.Text = "Examples";
            // 
            // radioButton_ImportIFS
            // 
            this.radioButton_ImportIFS.AutoSize = true;
            this.radioButton_ImportIFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_ImportIFS.Location = new System.Drawing.Point(21, 278);
            this.radioButton_ImportIFS.Name = "radioButton_ImportIFS";
            this.radioButton_ImportIFS.Size = new System.Drawing.Size(135, 28);
            this.radioButton_ImportIFS.TabIndex = 17;
            this.radioButton_ImportIFS.Text = "Imported IFS";
            this.radioButton_ImportIFS.UseVisualStyleBackColor = true;
            this.radioButton_ImportIFS.Click += new System.EventHandler(this.toolStripButton_Load_Click);
            // 
            // radioButton_SirCarp
            // 
            this.radioButton_SirCarp.AutoSize = true;
            this.radioButton_SirCarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SirCarp.Location = new System.Drawing.Point(21, 234);
            this.radioButton_SirCarp.Name = "radioButton_SirCarp";
            this.radioButton_SirCarp.Size = new System.Drawing.Size(169, 28);
            this.radioButton_SirCarp.TabIndex = 15;
            this.radioButton_SirCarp.Text = "Sierpiński Carpet";
            this.radioButton_SirCarp.UseVisualStyleBackColor = true;
            this.radioButton_SirCarp.CheckedChanged += new System.EventHandler(this.radioButton_SirCarp_CheckedChanged);
            // 
            // radioButton_Vic
            // 
            this.radioButton_Vic.AutoSize = true;
            this.radioButton_Vic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Vic.Location = new System.Drawing.Point(20, 190);
            this.radioButton_Vic.Name = "radioButton_Vic";
            this.radioButton_Vic.Size = new System.Drawing.Size(145, 28);
            this.radioButton_Vic.TabIndex = 14;
            this.radioButton_Vic.Text = "Vicsek Fractal";
            this.radioButton_Vic.UseVisualStyleBackColor = true;
            this.radioButton_Vic.CheckedChanged += new System.EventHandler(this.radioButton_Vic_CheckedChanged);
            // 
            // radioButton_SirPenta
            // 
            this.radioButton_SirPenta.AutoSize = true;
            this.radioButton_SirPenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_SirPenta.Location = new System.Drawing.Point(21, 144);
            this.radioButton_SirPenta.Name = "radioButton_SirPenta";
            this.radioButton_SirPenta.Size = new System.Drawing.Size(205, 28);
            this.radioButton_SirPenta.TabIndex = 13;
            this.radioButton_SirPenta.Text = "Sierpiński Pentagram";
            this.radioButton_SirPenta.UseVisualStyleBackColor = true;
            this.radioButton_SirPenta.CheckedChanged += new System.EventHandler(this.radioButton_SirPenta_CheckedChanged);
            // 
            // radioButton_CantorLab
            // 
            this.radioButton_CantorLab.AutoSize = true;
            this.radioButton_CantorLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_CantorLab.Location = new System.Drawing.Point(21, 97);
            this.radioButton_CantorLab.Name = "radioButton_CantorLab";
            this.radioButton_CantorLab.Size = new System.Drawing.Size(164, 28);
            this.radioButton_CantorLab.TabIndex = 12;
            this.radioButton_CantorLab.Text = "Cantor Labyrinth";
            this.radioButton_CantorLab.UseVisualStyleBackColor = true;
            this.radioButton_CantorLab.CheckedChanged += new System.EventHandler(this.radioButton_CantorLab_CheckedChanged);
            // 
            // radioButton_Koch
            // 
            this.radioButton_Koch.AutoSize = true;
            this.radioButton_Koch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Koch.Location = new System.Drawing.Point(20, 60);
            this.radioButton_Koch.Name = "radioButton_Koch";
            this.radioButton_Koch.Size = new System.Drawing.Size(127, 28);
            this.radioButton_Koch.TabIndex = 5;
            this.radioButton_Koch.Text = "Koch Curve";
            this.radioButton_Koch.UseVisualStyleBackColor = true;
            this.radioButton_Koch.CheckedChanged += new System.EventHandler(this.radioButton_Koch_CheckedChanged);
            // 
            // radioButton_Sirpinski
            // 
            this.radioButton_Sirpinski.AutoSize = true;
            this.radioButton_Sirpinski.Checked = true;
            this.radioButton_Sirpinski.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Sirpinski.Location = new System.Drawing.Point(20, 23);
            this.radioButton_Sirpinski.Name = "radioButton_Sirpinski";
            this.radioButton_Sirpinski.Size = new System.Drawing.Size(183, 28);
            this.radioButton_Sirpinski.TabIndex = 4;
            this.radioButton_Sirpinski.TabStop = true;
            this.radioButton_Sirpinski.Text = "Sierpiński Triangle";
            this.radioButton_Sirpinski.UseVisualStyleBackColor = true;
            this.radioButton_Sirpinski.CheckedChanged += new System.EventHandler(this.radioButton_Sirpinski_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Points
            // 
            this.textBox_Points.Location = new System.Drawing.Point(209, 95);
            this.textBox_Points.Name = "textBox_Points";
            this.textBox_Points.Size = new System.Drawing.Size(181, 20);
            this.textBox_Points.TabIndex = 32;
            this.textBox_Points.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Points_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Number of Iterations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_Points);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_Fractal);
            this.Controls.Add(this.textBox_IFSName);
            this.Controls.Add(this.FractalName);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Fractal Structures by Iterative Function System (IFS) - Iteration Image Processin" +
    "g";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox_Fractal.ResumeLayout(false);
            this.groupBox_Fractal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Start;
        private System.Windows.Forms.ToolStripButton toolStripButton_Safe;
        private System.Windows.Forms.ToolStripButton toolStripButton_Load;
        private System.Windows.Forms.ToolStripButton toolStripButton_Info;
        private System.Windows.Forms.ToolStripButton toolStripButton_Exit;
        private System.Windows.Forms.TextBox textBox_IFSName;
        private System.Windows.Forms.Label FractalName;
        private System.Windows.Forms.GroupBox groupBox_Fractal;
        private System.Windows.Forms.RadioButton radioButton_ImportIFS;
        private System.Windows.Forms.RadioButton radioButton_SirCarp;
        private System.Windows.Forms.RadioButton radioButton_Vic;
        private System.Windows.Forms.RadioButton radioButton_SirPenta;
        private System.Windows.Forms.RadioButton radioButton_CantorLab;
        private System.Windows.Forms.RadioButton radioButton_Koch;
        private System.Windows.Forms.RadioButton radioButton_Sirpinski;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Points;
        private System.Windows.Forms.Label label1;
    }
}

