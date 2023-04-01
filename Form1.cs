using WinFormsAppDemo.mod;

namespace WinFormsAppDemo {
    public partial class mainForm : Form {
        private db db_instance;
        public mainForm() {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e) {
            BlaBlaGenerator_Gen2 blaBlaGenerator = new();
            int numberOfSentences = 0;
            numberOfSentences = int.TryParse("0" + textBox_NumberOfSentences.Text, out numberOfSentences) ? numberOfSentences : 0 ;
            numberOfSentences = blaBlaGenerator.LimitNumberOfSenteces(numberOfSentences);
            textBox_NumberOfSentences.Text = numberOfSentences.ToString();
            textBox_NumberOfSentences.Refresh();
            blaBlaTextbox.Text = blaBlaGenerator.Generate(numberOfSentences);
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (db_instance is null) db_instance = new db();
            var data = new DbData(blaBlaTextbox.Text);
            db_instance.Save(data);


        }

        private void btnLoad_Click(object sender, EventArgs e) {
            if (db_instance is null) db_instance = new db();
            String txt = db_instance.Load();
            blaBlaTextbox.Text = txt;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            blaBlaTextbox.Text = "";
        }

        private async void btnExport_Click(object sender, EventArgs e) {
            try {
                String txt = blaBlaTextbox.Text;
                await File.WriteAllTextAsync("bla-bla.txt", txt);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnImport_Click(object sender, EventArgs e) {
            try {

                String txt = await File.ReadAllTextAsync("bla-bla.txt");
                blaBlaTextbox.Text = txt;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void mainForm_Load(object sender, EventArgs e) {

        }

        private void textBox_NumberOfSentences_Enter(object sender, EventArgs e) {

        }

        private void textBox_NumberOfSentences_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                generateButton_Click(sender, e);
            }
        }
    }
}