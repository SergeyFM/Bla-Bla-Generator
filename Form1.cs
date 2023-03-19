using WinFormsAppDemo.mod;

namespace WinFormsAppDemo
{
    public partial class mainForm : Form
    {
        private db db_instance;
        public mainForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            String[] words = "\r\n \r\n bla la dada kaba bum bam tam lam sam ham baba papa mama baba saka daka puki muki nea tam net moi tebe mne kriba lata krum blakadasa malaka taduka bik pra miru takuk tra".Split(' ');
            String[] punctuation = ". . . . . ! ?".Split(' ');

            int last = words.Length - 1;
            Random rnd = new Random();
            int textLength = 1000;
            String blaText = "";
            Boolean theFirstWordFlag = true;
            int currentLineLength = 0;

            while (textLength > 0)
            {
                textLength--;
                String randomWord = words[rnd.Next(0, last)];
                currentLineLength += randomWord.Length;
                if (currentLineLength > 80) randomWord = "\r\n";
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
                    if (!punctuation.Contains((blaText+" ").Trim().Last().ToString()))
                    {
                        blaText = blaText.Trim() + punctuation[rnd.Next(punctuation.Length)];
                    }
                    int kubik = rnd.Next(1, 4);
                    if (currentLineLength < 10 || kubik == 1)
                    {
                        if (currentLineLength > 2) blaText += " ";
                        continue;
                    }
                    currentLineLength = 0;
                }

                blaText += randomWord + space;
            }
            blaBlaTextbox.Text = blaText;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (db_instance is null) db_instance = new db();
            var data = new DbData(blaBlaTextbox.Text);
            db_instance.Save(data);


        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (db_instance is null) db_instance = new db();
            String txt = db_instance.Load();
            blaBlaTextbox.Text = txt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            blaBlaTextbox.Text = "";
        }
    }
}