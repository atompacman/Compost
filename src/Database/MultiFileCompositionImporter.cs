using System.Windows.Forms;

namespace Compost.Database
{
    public partial class MultiFileCompositionImporter : Form
    {
        public MultiFileCompositionImporter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();
            foreach (string file in dialog.FileNames)
            {
                if (!listView1.Items.ContainsKey(file))
                {
                    var item = listView1.Items.Add(file, file, 0);
                }
            }
        }
    }
}
