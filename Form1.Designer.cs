namespace MyProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMediaPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rewindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastforwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cbVizualizat = new System.Windows.Forms.CheckBox();
            this.cbNota = new System.Windows.Forms.ComboBox();
            this.clbGen = new System.Windows.Forms.CheckedListBox();
            this.labelNota = new System.Windows.Forms.Label();
            this.labelGen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvVideoPlayer = new System.Windows.Forms.ListView();
            this.chDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVizualizat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reimprospatareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnPreluareBD = new System.Windows.Forms.Button();
            this.btnInserare = new System.Windows.Forms.Button();
            this.btnEditare = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tvFilme = new System.Windows.Forms.TreeView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 27);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(202, 171);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMediaPlayerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMediaPlayerToolStripMenuItem
            // 
            this.openMediaPlayerToolStripMenuItem.Name = "openMediaPlayerToolStripMenuItem";
            this.openMediaPlayerToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openMediaPlayerToolStripMenuItem.Text = "Open MediaPlayer";
            this.openMediaPlayerToolStripMenuItem.Click += new System.EventHandler(this.openMediaPlayerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.rewindToolStripMenuItem,
            this.fastforwardToolStripMenuItem,
            this.fullscreenToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // rewindToolStripMenuItem
            // 
            this.rewindToolStripMenuItem.Name = "rewindToolStripMenuItem";
            this.rewindToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.rewindToolStripMenuItem.Text = "Rewind";
            this.rewindToolStripMenuItem.Click += new System.EventHandler(this.rewindToolStripMenuItem_Click);
            // 
            // fastforwardToolStripMenuItem
            // 
            this.fastforwardToolStripMenuItem.Name = "fastforwardToolStripMenuItem";
            this.fastforwardToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fastforwardToolStripMenuItem.Text = "Fast-forward";
            this.fastforwardToolStripMenuItem.Click += new System.EventHandler(this.fastforwardToolStripMenuItem_Click);
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            this.fullscreenToolStripMenuItem.Click += new System.EventHandler(this.fullscreenToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cbVizualizat
            // 
            this.cbVizualizat.AutoSize = true;
            this.cbVizualizat.Location = new System.Drawing.Point(17, 19);
            this.cbVizualizat.Name = "cbVizualizat";
            this.cbVizualizat.Size = new System.Drawing.Size(132, 17);
            this.cbVizualizat.TabIndex = 1;
            this.cbVizualizat.Text = "Vizualizat/Nevizualizat";
            this.cbVizualizat.UseVisualStyleBackColor = true;
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
            this.cbNota.Location = new System.Drawing.Point(17, 51);
            this.cbNota.Name = "cbNota";
            this.cbNota.Size = new System.Drawing.Size(63, 21);
            this.cbNota.TabIndex = 2;
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
            this.clbGen.Location = new System.Drawing.Point(17, 78);
            this.clbGen.Name = "clbGen";
            this.clbGen.Size = new System.Drawing.Size(102, 94);
            this.clbGen.TabIndex = 3;
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(89, 51);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(30, 13);
            this.labelNota.TabIndex = 5;
            this.labelNota.Text = "Nota";
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Location = new System.Drawing.Point(125, 78);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(27, 13);
            this.labelGen.TabIndex = 6;
            this.labelGen.Text = "Gen";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.clbGen);
            this.groupBox1.Controls.Add(this.labelGen);
            this.groupBox1.Controls.Add(this.cbNota);
            this.groupBox1.Controls.Add(this.labelNota);
            this.groupBox1.Controls.Add(this.cbVizualizat);
            this.groupBox1.Location = new System.Drawing.Point(222, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Nou";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lvVideoPlayer
            // 
            this.lvVideoPlayer.AllowColumnReorder = true;
            this.lvVideoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvVideoPlayer.CheckBoxes = true;
            this.lvVideoPlayer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDenumire,
            this.chNota,
            this.chGen,
            this.chVizualizat});
            this.lvVideoPlayer.ContextMenuStrip = this.contextMenuStrip1;
            this.lvVideoPlayer.FullRowSelect = true;
            this.lvVideoPlayer.GridLines = true;
            this.lvVideoPlayer.LabelEdit = true;
            this.lvVideoPlayer.Location = new System.Drawing.Point(12, 250);
            this.lvVideoPlayer.Name = "lvVideoPlayer";
            this.lvVideoPlayer.Size = new System.Drawing.Size(384, 131);
            this.lvVideoPlayer.TabIndex = 4;
            this.lvVideoPlayer.UseCompatibleStateImageBehavior = false;
            this.lvVideoPlayer.View = System.Windows.Forms.View.Details;
            // 
            // chDenumire
            // 
            this.chDenumire.Text = "Denumire";
            this.chDenumire.Width = 150;
            // 
            // chNota
            // 
            this.chNota.Text = "Nota";
            this.chNota.Width = 37;
            // 
            // chGen
            // 
            this.chGen.Text = "Gen";
            this.chGen.Width = 144;
            // 
            // chVizualizat
            // 
            this.chVizualizat.Text = "Vizualizat/Nevizualizat";
            this.chVizualizat.Width = 126;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reimprospatareToolStripMenuItem,
            this.sortareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 48);
            // 
            // reimprospatareToolStripMenuItem
            // 
            this.reimprospatareToolStripMenuItem.Name = "reimprospatareToolStripMenuItem";
            this.reimprospatareToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.reimprospatareToolStripMenuItem.Text = "Reimprospatare";
            this.reimprospatareToolStripMenuItem.Click += new System.EventHandler(this.reimprospatareToolStripMenuItem_Click_1);
            // 
            // sortareToolStripMenuItem
            // 
            this.sortareToolStripMenuItem.Name = "sortareToolStripMenuItem";
            this.sortareToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sortareToolStripMenuItem.Text = "Sortare";
            this.sortareToolStripMenuItem.Click += new System.EventHandler(this.sortareToolStripMenuItem_Click_1);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(402, 39);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(76, 23);
            this.btnAdauga.TabIndex = 9;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(403, 68);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(75, 23);
            this.btnSterge.TabIndex = 11;
            this.btnSterge.Text = "Stergere";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnPreluareBD
            // 
            this.btnPreluareBD.Location = new System.Drawing.Point(402, 100);
            this.btnPreluareBD.Name = "btnPreluareBD";
            this.btnPreluareBD.Size = new System.Drawing.Size(125, 23);
            this.btnPreluareBD.TabIndex = 12;
            this.btnPreluareBD.Text = "Preluare Date din DB";
            this.btnPreluareBD.UseVisualStyleBackColor = true;
            this.btnPreluareBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btnInserare
            // 
            this.btnInserare.Location = new System.Drawing.Point(402, 129);
            this.btnInserare.Name = "btnInserare";
            this.btnInserare.Size = new System.Drawing.Size(124, 23);
            this.btnInserare.TabIndex = 13;
            this.btnInserare.Text = "Inserare Manuala";
            this.btnInserare.UseVisualStyleBackColor = true;
            this.btnInserare.Click += new System.EventHandler(this.btnInserare_Click);
            // 
            // btnEditare
            // 
            this.btnEditare.Location = new System.Drawing.Point(402, 158);
            this.btnEditare.Name = "btnEditare";
            this.btnEditare.Size = new System.Drawing.Size(125, 23);
            this.btnEditare.TabIndex = 15;
            this.btnEditare.Text = "Editare in DB";
            this.btnEditare.UseVisualStyleBackColor = true;
            this.btnEditare.Click += new System.EventHandler(this.btnEditare_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Print Preview Dialog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Print Document";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(414, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Alege cale";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tvFilme
            // 
            this.tvFilme.Location = new System.Drawing.Point(414, 250);
            this.tvFilme.Name = "tvFilme";
            this.tvFilme.Size = new System.Drawing.Size(211, 131);
            this.tvFilme.TabIndex = 19;
            this.tvFilme.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFilme_AfterSelect);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(402, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Inserare in DB";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 413);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Cauta";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 413);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 446);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tvFilme);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditare);
            this.Controls.Add(this.btnInserare);
            this.Controls.Add(this.btnPreluareBD);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lvVideoPlayer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastforwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rewindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMediaPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.CheckBox cbVizualizat;
        private System.Windows.Forms.ComboBox cbNota;
        private System.Windows.Forms.CheckedListBox clbGen;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvVideoPlayer;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ColumnHeader chDenumire;
        private System.Windows.Forms.ColumnHeader chNota;
        private System.Windows.Forms.ColumnHeader chGen;
        private System.Windows.Forms.ColumnHeader chVizualizat;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnPreluareBD;
        private System.Windows.Forms.Button btnInserare;
        private System.Windows.Forms.Button btnEditare;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reimprospatareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortareToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView tvFilme;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

