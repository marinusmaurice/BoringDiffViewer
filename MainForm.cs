//Author: Maurice Marinus
//Licence: MIT
namespace WindowsDiffViewer
{
    public partial class MainForm : Form
    {
        Merged merged = null;
        string lFile = string.Empty;
        string rFile = string.Empty;
        public MainForm()
        {
            InitializeComponent();
             
            merged = new Merged();
            miMatchPerWord_Click(null, new EventArgs());
            miTextbox_Click(null, new EventArgs());
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            rtbLeft.Width = this.Width / 3;
            rtbRight.Width = this.Width / 3;
            rtbMerge.Width = this.Width / 3;
        }

        private void open1toolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var f = new OpenFileDialog())
            {
                f.Title = "Select a file for the left side";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    rtbLeft.Text = File.ReadAllText(f.FileName);
                    lFile = f.FileName;
                }
            }
        }

        private void open2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new OpenFileDialog())
            {
                f.Title = "Select a file for the right side";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    rtbRight.Text = File.ReadAllText(f.FileName);
                    rFile = f.FileName;
                }
            }
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ddbReadFrom.Text == "File")
            {
               
                try
                {
                    if (lFile == string.Empty)
                    {
                        open1toolStripMenuItem_Click(null, new EventArgs());
                    }
                    merged.Left = File.ReadAllText(lFile);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on trying to read file 1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try 
                {
                    if (rFile == string.Empty)
                    {
                        open2ToolStripMenuItem_Click(null, new EventArgs());
                    }
                    merged.Right = File.ReadAllText(rFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on trying to read file 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (ddbReadFrom.Text == "Textbox")
            {
                merged.Left = rtbLeft.Text;
                merged.Right = rtbRight.Text;
            }
            var output = merged.Diff();

            if (!merged.Test(output, WhereIn.Both))
            {
                MessageBox.Show("Reassembling of files not matched");
            }

            rtbMerge.Clear();
            rtbMerge.SuspendLayout();
            foreach (var item in output)
            {
                switch (item.WhereIn)
                {
                    case WhereIn.Both:
                        rtbMerge.AppendText(item.Value, merged.BothColor);
                        break;
                    case WhereIn.Left:
                        rtbMerge.AppendText(item.Value, merged.LeftColor);
                        break;
                    case WhereIn.Right:
                        rtbMerge.AppendText(item.Value, merged.RightColor);
                        break;
                    default:
                        rtbMerge.AppendText(item.Value, Color.Blue);
                        break;
                }
            }
            rtbMerge.ResumeLayout();
        }

        private void miMatchPerCharacter_Click(object sender, EventArgs e)
        {
            merged.MatchPer = MatchPer.Character;
            ddbMatchPer.Text = "Character";
        }

        private void miMatchPerWord_Click(object sender, EventArgs e)
        {
            merged.MatchPer = MatchPer.Word;
            ddbMatchPer.Text = "Word";
        }

        private void miMatchPerLine_Click(object sender, EventArgs e)
        {
            merged.MatchPer = MatchPer.Line;
            ddbMatchPer.Text = "Line";
        }

        private void miTextbox_Click(object sender, EventArgs e)
        {
            ddbReadFrom.Text = "Textbox";
            ddbReadFrom.ToolTipText = "Compares text in textbox";
        }

        private void miFile_Click(object sender, EventArgs e)
        {
            ddbReadFrom.Text = "File";
            ddbReadFrom.ToolTipText = "Compares text per selected file (Better for line comparison)";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = @"This is an implementation of a simple diffing algorithm
The critical part works as follows:
if item matches on left and right
-output it
-continue loop
if item on left and right doesn't match
-find first item that intersect from both sides
-output everything on left and right side up to but not including the first intersecting item
-continue loop
-if no items intersect
--output everything on left and right side
--exit function";
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionBackColor = color;
            box.AppendText(text);
            box.SelectionBackColor = box.ForeColor;
        }
    }
}