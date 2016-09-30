namespace MyProject
{
    partial class Form2
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
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNota = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clbGen = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVizualizat = new System.Windows.Forms.CheckBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.erDenumire = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erDenumire)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(131, 24);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(100, 20);
            this.tbDenumire.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Denumire";
            // 
            // cbNota
            // 
            this.cbNota.FormattingEnabled = true;
            this.cbNota.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbNota.Location = new System.Drawing.Point(131, 66);
            this.cbNota.Name = "cbNota";
            this.cbNota.Size = new System.Drawing.Size(64, 21);
            this.cbNota.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota";
            // 
            // clbGen
            // 
            this.clbGen.FormattingEnabled = true;
            this.clbGen.Items.AddRange(new object[] {
            "Acţiune",
            "Animaţie",
            "Aventuri",
            "Biografic",
            "Comedie ",
            "Crimă",
            "Documentar",
            "Dragoste",
            "Dramă",
            "Erotic ",
            "Familie",
            "Fantastic",
            "Film noir",
            "Horror",
            "Istoric ",
            "Mister",
            "Muzical",
            "Război",
            "Reality TV",
            "Romantic ",
            "Scurt metraj",
            "Science Fiction",
            "Sport",
            "Thriller",
            "Western"});
            this.clbGen.Location = new System.Drawing.Point(131, 116);
            this.clbGen.Name = "clbGen";
            this.clbGen.Size = new System.Drawing.Size(120, 94);
            this.clbGen.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gen";
            // 
            // cbVizualizat
            // 
            this.cbVizualizat.AutoSize = true;
            this.cbVizualizat.Location = new System.Drawing.Point(131, 217);
            this.cbVizualizat.Name = "cbVizualizat";
            this.cbVizualizat.Size = new System.Drawing.Size(132, 17);
            this.cbVizualizat.TabIndex = 6;
            this.cbVizualizat.Text = "Vizualizat/Nevizualizat";
            this.cbVizualizat.UseVisualStyleBackColor = true;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(19, 226);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(96, 23);
            this.btnAdauga.TabIndex = 7;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // erDenumire
            // 
            this.erDenumire.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.cbVizualizat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbGen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbNota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDenumire);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erDenumire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbGen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbVizualizat;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ErrorProvider erDenumire;
    }
}