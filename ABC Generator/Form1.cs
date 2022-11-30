using System;
using System.Windows.Forms;

namespace ABC_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SearchPattern.Text = "*.spr";
            DentityNo.Text = "26001";
        }

        private string GetJobNameString(string fileName)
        {
            if (fileName.Length == 0) return "Invalid Filename";

            return "[jobtbl.JT_" + fileName.ToUpper() + "] = \"" + fileName + "\"";
        }

        private string GetNpcIdentityString(string fileName, int dentityNo)
        {
            if (fileName.Length == 0) return "Invalid Filename";
            if (dentityNo < 1) return "Invalid DentityNo";

            return "JT_" + fileName.ToUpper() + " = " + dentityNo.ToString();
        }

        private string RemoveEndOfString(string txt)
        {
            if (txt.Length < 1) return "Invalid Txt End of String";

            return txt.Substring(0, txt.Length - 2);
        }
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            string targetPath = TargetPath.Text;
            if (targetPath.Length < 1) return;

            string searchPattern = (SearchPattern.Text.Length > 0 ? SearchPattern.Text : "");
            string[] filePaths = System.IO.Directory.GetFiles(targetPath, searchPattern);

            ResultJobName.ResetText();
            ResultNpcDentity.ResetText();

            int dentityNo;
            if (!int.TryParse(DentityNo.Text, out dentityNo)) MessageBox.Show("Invalid Dentity No");

            foreach (string filePath in filePaths)
            {
                string fileName = System.IO.Path.GetFileNameWithoutExtension(filePath);

                ResultJobName.Text += GetJobNameString(fileName) + "," + Environment.NewLine;
                ResultNpcDentity.Text += GetNpcIdentityString(fileName, dentityNo) + "," + Environment.NewLine;
                dentityNo++;
            }

            ResultJobName.Text = RemoveEndOfString(ResultJobName.Text);
            ResultNpcDentity.Text = RemoveEndOfString(ResultNpcDentity.Text);
        }

    }
}
