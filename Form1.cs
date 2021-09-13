using System;
using System.IO;
using System.Windows.Forms;

namespace test2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Btn_SaveText_Click(object sender, EventArgs e)
        {
            SaveText(Txtbox_content.Text);
        }
        private void SaveText(string textContent)
        {
            var isTextEmpty = String.IsNullOrWhiteSpace(Txtbox_content.Text);

            if (isTextEmpty)
            {
                MessageBox.Show("You must write something first.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var savePath = SaveFileDialog1.FileName + ".txt";
                File.WriteAllText(savePath, textContent.Trim());
                MessageBox.Show("The file was created", "Test 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
