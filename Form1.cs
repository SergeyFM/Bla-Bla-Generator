using System.DirectoryServices.ActiveDirectory;

namespace WinFormsAppDemo
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            String[] words = "\r\n \r\n bla la dada kaba bum bam tam lam sam ham baba papa mama baba saka daka puki muki nea tam net moi tebe mne".Split(' ');

            int last = words.Length - 1;
            Random rnd = new Random();
            int textLength = 1000;
            String blaText = "";
            Boolean theFirstWordFlag = true;

            while (textLength > 0)
            {
                textLength--;
                String randomWord = words[rnd.Next(0, last)];
                if (theFirstWordFlag && randomWord.Trim().Length > 1)
                {
                    randomWord = randomWord.Substring(0, 1).ToUpper() + randomWord.Substring(1);
                    theFirstWordFlag = false;
                }
                String space = " ";
                if (randomWord == "\r\n")
                {
                    space = "";
                    theFirstWordFlag = true;
                }

                blaText += randomWord + space;
            }
            blaBlaTextbox.Text = blaText;
        }
    }
}