
namespace MiniWord_VoQuocHung
{
    partial class frmQuocHung
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTb = new System.Windows.Forms.RichTextBox();
            this.cbbFont = new System.Windows.Forms.ComboBox();
            this.cbbFontSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlChinh = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnIcon = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChenAnh = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnrigth = new System.Windows.Forms.Button();
            this.btncenter = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNenChu = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.pnlChinh.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.btnSaveAs,
            this.btnClose,
            this.exitToolStripMenuItem});
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.openFileToolStripMenuItem.Text = "File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::MiniWord_VoQuocHung.Properties.Resources.icons8_new_file_64;
            this.btnNew.Name = "btnNew";
            this.btnNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNew.Size = new System.Drawing.Size(197, 26);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Image = global::MiniWord_VoQuocHung.Properties.Resources.icons8_open_file_under_cursor_48;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnOpen.Size = new System.Drawing.Size(197, 26);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::MiniWord_VoQuocHung.Properties.Resources.icons8_save_48;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(224, 26);
            this.btnSave.Text = "Save ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Image = global::MiniWord_VoQuocHung.Properties.Resources.icons8_save_48;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSaveAs.Size = new System.Drawing.Size(197, 26);
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::MiniWord_VoQuocHung.Properties.Resources.icons8_save_close_30;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(197, 26);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::MiniWord_VoQuocHung.Properties.Resources.icons8_exit_48;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // richTb
            // 
            this.richTb.Location = new System.Drawing.Point(153, 163);
            this.richTb.Name = "richTb";
            this.richTb.Size = new System.Drawing.Size(770, 608);
            this.richTb.TabIndex = 1;
            this.richTb.Text = "";
            this.richTb.SelectionChanged += new System.EventHandler(this.richTb_SelectionChanged);
            // 
            // cbbFont
            // 
            this.cbbFont.FormattingEnabled = true;
            this.cbbFont.Location = new System.Drawing.Point(15, 8);
            this.cbbFont.Name = "cbbFont";
            this.cbbFont.Size = new System.Drawing.Size(162, 24);
            this.cbbFont.TabIndex = 0;
            this.cbbFont.SelectedIndexChanged += new System.EventHandler(this.cbbFont_SelectedIndexChanged);
            // 
            // cbbFontSize
            // 
            this.cbbFontSize.FormattingEnabled = true;
            this.cbbFontSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cbbFontSize.Location = new System.Drawing.Point(199, 8);
            this.cbbFontSize.Name = "cbbFontSize";
            this.cbbFontSize.Size = new System.Drawing.Size(59, 24);
            this.cbbFontSize.TabIndex = 1;
            this.cbbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbbFontSize_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Paste";
            // 
            // pnlChinh
            // 
            this.pnlChinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlChinh.Controls.Add(this.panel6);
            this.pnlChinh.Controls.Add(this.panel5);
            this.pnlChinh.Controls.Add(this.panel4);
            this.pnlChinh.Controls.Add(this.panel3);
            this.pnlChinh.Controls.Add(this.panel2);
            this.pnlChinh.Location = new System.Drawing.Point(0, 31);
            this.pnlChinh.Name = "pnlChinh";
            this.pnlChinh.Size = new System.Drawing.Size(1077, 131);
            this.pnlChinh.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel6.Controls.Add(this.btnIcon);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.btnZoomOut);
            this.panel6.Controls.Add(this.btnZoomIn);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.button7);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.btnFind);
            this.panel6.Controls.Add(this.Find);
            this.panel6.Location = new System.Drawing.Point(714, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(350, 122);
            this.panel6.TabIndex = 10;
            // 
            // btnIcon
            // 
            this.btnIcon.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_medium_icons_40;
            this.btnIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIcon.FlatAppearance.BorderSize = 0;
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.Location = new System.Drawing.Point(12, 78);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(28, 31);
            this.btnIcon.TabIndex = 18;
            this.btnIcon.TabStop = false;
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(43, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Icon";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_zoom_out_64;
            this.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomOut.FlatAppearance.BorderSize = 0;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Location = new System.Drawing.Point(94, 40);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(28, 31);
            this.btnZoomOut.TabIndex = 16;
            this.btnZoomOut.TabStop = false;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_zoom_in_100;
            this.btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZoomIn.FlatAppearance.BorderSize = 0;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Location = new System.Drawing.Point(87, 1);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(42, 44);
            this.btnZoomIn.TabIndex = 15;
            this.btnZoomIn.TabStop = false;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(121, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Zoom out";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(126, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Zoom in";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(166, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 22);
            this.label8.TabIndex = 12;
            this.label8.Text = "Edit";
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_replace_64;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(12, 40);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 31);
            this.button7.TabIndex = 10;
            this.button7.TabStop = false;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Replace";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_find_and_replace_64;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(12, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(28, 31);
            this.btnFind.TabIndex = 8;
            this.btnFind.TabStop = false;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Find
            // 
            this.Find.AutoSize = true;
            this.Find.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Find.ForeColor = System.Drawing.Color.White;
            this.Find.Location = new System.Drawing.Point(41, 12);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(33, 16);
            this.Find.TabIndex = 7;
            this.Find.Text = "Find";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnChenAnh);
            this.panel5.Location = new System.Drawing.Point(612, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(95, 122);
            this.panel5.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Insert";
            // 
            // btnChenAnh
            // 
            this.btnChenAnh.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_picture_64;
            this.btnChenAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChenAnh.FlatAppearance.BorderSize = 0;
            this.btnChenAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChenAnh.Location = new System.Drawing.Point(13, 11);
            this.btnChenAnh.Name = "btnChenAnh";
            this.btnChenAnh.Size = new System.Drawing.Size(66, 69);
            this.btnChenAnh.TabIndex = 0;
            this.btnChenAnh.TabStop = false;
            this.btnChenAnh.UseVisualStyleBackColor = true;
            this.btnChenAnh.Click += new System.EventHandler(this.btnChenAnh_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel4.Controls.Add(this.btnrigth);
            this.panel4.Controls.Add(this.btncenter);
            this.panel4.Controls.Add(this.btnleft);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(452, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 122);
            this.panel4.TabIndex = 8;
            // 
            // btnrigth
            // 
            this.btnrigth.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_align_right_50;
            this.btnrigth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrigth.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnrigth.FlatAppearance.BorderSize = 2;
            this.btnrigth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrigth.Location = new System.Drawing.Point(104, 41);
            this.btnrigth.Name = "btnrigth";
            this.btnrigth.Size = new System.Drawing.Size(39, 37);
            this.btnrigth.TabIndex = 11;
            this.btnrigth.UseVisualStyleBackColor = true;
            this.btnrigth.Click += new System.EventHandler(this.btnrigth_Click);
            // 
            // btncenter
            // 
            this.btncenter.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_align_center_50;
            this.btncenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncenter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncenter.FlatAppearance.BorderSize = 2;
            this.btncenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncenter.Location = new System.Drawing.Point(61, 41);
            this.btncenter.Name = "btncenter";
            this.btncenter.Size = new System.Drawing.Size(39, 37);
            this.btncenter.TabIndex = 10;
            this.btncenter.UseVisualStyleBackColor = true;
            this.btncenter.Click += new System.EventHandler(this.btncenter_Click);
            // 
            // btnleft
            // 
            this.btnleft.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_align_left_50;
            this.btnleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnleft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnleft.FlatAppearance.BorderSize = 2;
            this.btnleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnleft.Location = new System.Drawing.Point(17, 41);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(39, 37);
            this.btnleft.TabIndex = 9;
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Italic);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(38, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "paragraph";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnPaste);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnCopy);
            this.panel3.Controls.Add(this.btnCut);
            this.panel3.Location = new System.Drawing.Point(4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 122);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clipboard";
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPaste.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_paste_as_text_40;
            this.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaste.FlatAppearance.BorderSize = 0;
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPaste.Location = new System.Drawing.Point(24, 11);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(67, 58);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.TabStop = false;
            this.btnPaste.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCopy.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_copy_64;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(102, 49);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(29, 26);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.TabStop = false;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCut.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_cut_64;
            this.btnCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCut.FlatAppearance.BorderSize = 0;
            this.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCut.Location = new System.Drawing.Point(99, 11);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(29, 24);
            this.btnCut.TabIndex = 5;
            this.btnCut.TabStop = false;
            this.btnCut.UseVisualStyleBackColor = false;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.btnItalic);
            this.panel2.Controls.Add(this.btnUnderline);
            this.panel2.Controls.Add(this.btnBold);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnNenChu);
            this.panel2.Controls.Add(this.btnColor);
            this.panel2.Controls.Add(this.cbbFont);
            this.panel2.Controls.Add(this.cbbFontSize);
            this.panel2.Location = new System.Drawing.Point(158, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 122);
            this.panel2.TabIndex = 7;
            // 
            // btnItalic
            // 
            this.btnItalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnItalic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItalic.FlatAppearance.BorderSize = 2;
            this.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalic.Location = new System.Drawing.Point(75, 50);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(39, 37);
            this.btnItalic.TabIndex = 14;
            this.btnItalic.Text = "I";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnTypeText_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnderline.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUnderline.FlatAppearance.BorderSize = 2;
            this.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderline.Location = new System.Drawing.Point(116, 50);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(39, 37);
            this.btnUnderline.TabIndex = 13;
            this.btnUnderline.Text = "U";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnTypeText_Click);
            // 
            // btnBold
            // 
            this.btnBold.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBold.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBold.FlatAppearance.BorderSize = 2;
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.Location = new System.Drawing.Point(34, 50);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(39, 37);
            this.btnBold.TabIndex = 12;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = false;
            this.btnBold.Click += new System.EventHandler(this.btnTypeText_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(130, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Font";
            // 
            // btnNenChu
            // 
            this.btnNenChu.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_pen_64;
            this.btnNenChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNenChu.FlatAppearance.BorderSize = 2;
            this.btnNenChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNenChu.Location = new System.Drawing.Point(229, 50);
            this.btnNenChu.Name = "btnNenChu";
            this.btnNenChu.Size = new System.Drawing.Size(39, 37);
            this.btnNenChu.TabIndex = 3;
            this.btnNenChu.UseVisualStyleBackColor = true;
            this.btnNenChu.Click += new System.EventHandler(this.btnNenChu_Click);
            // 
            // btnColor
            // 
            this.btnColor.FlatAppearance.BorderSize = 2;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnColor.Location = new System.Drawing.Point(189, 50);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(39, 37);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "A";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(25, 25);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnUndo
            // 
            this.btnUndo.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_arrow_left_64;
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Location = new System.Drawing.Point(194, 3);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(22, 22);
            this.btnUndo.TabIndex = 17;
            this.btnUndo.TabStop = false;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.BackgroundImage = global::MiniWord_VoQuocHung.Properties.Resources.icons8_right_64;
            this.btnRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRedo.FlatAppearance.BorderSize = 0;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Location = new System.Drawing.Point(225, 3);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(22, 22);
            this.btnRedo.TabIndex = 18;
            this.btnRedo.TabStop = false;
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(715, 163);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(349, 256);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseLeave += new System.EventHandler(this.listView1_MouseLeave);
            // 
            // frmQuocHung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 776);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.pnlChinh);
            this.Controls.Add(this.richTb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuocHung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordPadMini";
            this.Load += new System.EventHandler(this.frmQuocHung_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlChinh.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnSaveAs;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTb;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.ComboBox cbbFontSize;
        private System.Windows.Forms.ComboBox cbbFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Panel pnlChinh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnChenAnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNenChu;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label Find;
        private System.Windows.Forms.Button btnrigth;
        private System.Windows.Forms.Button btncenter;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
    }
}

