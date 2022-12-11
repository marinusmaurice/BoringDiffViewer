namespace WindowsDiffViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ddbMatchPer = new System.Windows.Forms.ToolStripDropDownButton();
            this.miMatchPerCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.miMatchPerWord = new System.Windows.Forms.ToolStripMenuItem();
            this.miMatchPerLine = new System.Windows.Forms.ToolStripMenuItem();
            this.ddbReadFrom = new System.Windows.Forms.ToolStripDropDownButton();
            this.miTextbox = new System.Windows.Forms.ToolStripMenuItem();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open1toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbLeft = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.rtbRight = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.rtbMerge = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddbMatchPer,
            this.ddbReadFrom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ddbMatchPer
            // 
            this.ddbMatchPer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbMatchPer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMatchPerCharacter,
            this.miMatchPerWord,
            this.miMatchPerLine});
            this.ddbMatchPer.Image = ((System.Drawing.Image)(resources.GetObject("ddbMatchPer.Image")));
            this.ddbMatchPer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbMatchPer.Name = "ddbMatchPer";
            this.ddbMatchPer.Size = new System.Drawing.Size(164, 20);
            this.ddbMatchPer.Text = "toolStripDropDownButton1";
            // 
            // miMatchPerCharacter
            // 
            this.miMatchPerCharacter.Name = "miMatchPerCharacter";
            this.miMatchPerCharacter.Size = new System.Drawing.Size(125, 22);
            this.miMatchPerCharacter.Text = "Character";
            this.miMatchPerCharacter.Click += new System.EventHandler(this.miMatchPerCharacter_Click);
            // 
            // miMatchPerWord
            // 
            this.miMatchPerWord.Name = "miMatchPerWord";
            this.miMatchPerWord.Size = new System.Drawing.Size(125, 22);
            this.miMatchPerWord.Text = "Word";
            this.miMatchPerWord.Click += new System.EventHandler(this.miMatchPerWord_Click);
            // 
            // miMatchPerLine
            // 
            this.miMatchPerLine.Name = "miMatchPerLine";
            this.miMatchPerLine.Size = new System.Drawing.Size(125, 22);
            this.miMatchPerLine.Text = "Line";
            this.miMatchPerLine.Click += new System.EventHandler(this.miMatchPerLine_Click);
            // 
            // ddbReadFrom
            // 
            this.ddbReadFrom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbReadFrom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTextbox,
            this.miFile});
            this.ddbReadFrom.Image = ((System.Drawing.Image)(resources.GetObject("ddbReadFrom.Image")));
            this.ddbReadFrom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbReadFrom.Name = "ddbReadFrom";
            this.ddbReadFrom.Size = new System.Drawing.Size(164, 20);
            this.ddbReadFrom.Text = "toolStripDropDownButton1";
            // 
            // miTextbox
            // 
            this.miTextbox.Name = "miTextbox";
            this.miTextbox.Size = new System.Drawing.Size(115, 22);
            this.miTextbox.Text = "&Textbox";
            this.miTextbox.Click += new System.EventHandler(this.miTextbox_Click);
            // 
            // miFile
            // 
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(115, 22);
            this.miFile.Text = "&File";
            this.miFile.Click += new System.EventHandler(this.miFile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open1toolStripMenuItem,
            this.open2ToolStripMenuItem,
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // open1toolStripMenuItem
            // 
            this.open1toolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("open1toolStripMenuItem.Image")));
            this.open1toolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open1toolStripMenuItem.Name = "open1toolStripMenuItem";
            this.open1toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open1toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.open1toolStripMenuItem.Text = "Open File &1";
            this.open1toolStripMenuItem.Click += new System.EventHandler(this.open1toolStripMenuItem_Click);
            // 
            // open2ToolStripMenuItem
            // 
            this.open2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("open2ToolStripMenuItem.Image")));
            this.open2ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open2ToolStripMenuItem.Name = "open2ToolStripMenuItem";
            this.open2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.open2ToolStripMenuItem.Text = "Open File &2";
            this.open2ToolStripMenuItem.Click += new System.EventHandler(this.open2ToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compareToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // compareToolStripMenuItem
            // 
            this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            this.compareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.compareToolStripMenuItem.Text = "&Compare";
            this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // rtbLeft
            // 
            this.rtbLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbLeft.Location = new System.Drawing.Point(0, 24);
            this.rtbLeft.Name = "rtbLeft";
            this.rtbLeft.Size = new System.Drawing.Size(100, 404);
            this.rtbLeft.TabIndex = 2;
            this.rtbLeft.Text = "";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(100, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 404);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // rtbRight
            // 
            this.rtbRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbRight.Location = new System.Drawing.Point(103, 24);
            this.rtbRight.Name = "rtbRight";
            this.rtbRight.Size = new System.Drawing.Size(150, 404);
            this.rtbRight.TabIndex = 4;
            this.rtbRight.Text = "";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(253, 24);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 404);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // rtbMerge
            // 
            this.rtbMerge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMerge.Location = new System.Drawing.Point(256, 24);
            this.rtbMerge.Name = "rtbMerge";
            this.rtbMerge.Size = new System.Drawing.Size(544, 404);
            this.rtbMerge.TabIndex = 6;
            this.rtbMerge.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbMerge);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.rtbRight);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.rtbLeft);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge View";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem open2ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private RichTextBox rtbLeft;
        private Splitter splitter1;
        private RichTextBox rtbRight;
        private Splitter splitter2;
        private RichTextBox rtbMerge;
        private ToolStripMenuItem open1toolStripMenuItem;
        private ToolStripMenuItem compareToolStripMenuItem;
        private ToolStripDropDownButton ddbMatchPer;
        private ToolStripMenuItem miMatchPerCharacter;
        private ToolStripMenuItem miMatchPerWord;
        private ToolStripMenuItem miMatchPerLine;
        private ToolStripDropDownButton ddbReadFrom;
        private ToolStripMenuItem miTextbox;
        private ToolStripMenuItem miFile;
    }
}