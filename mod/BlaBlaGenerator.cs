namespace WinFormsAppDemo.mod {
    internal class BlaBlaGenerator {
        private static String[] words = "\r\n \r\n bla la dada kaba bum bam tam lam sam ham baba papa mama baba saka daka puki muki nea tam net moi tebe mne kriba lata krum bakadasa malaka taduka bik pra eiru takuk tra bit tra prita dla talla pikula mlita".Split(' '); 
        public String Generate() {

            String[] punctuation = ". . . . . ! ?".Split(' ');

            int last = words.Length - 1;
            Random rnd = new Random();
            int textLength = 1000;
            String blaText = "";
            Boolean theFirstWordFlag = true;
            int currentLineLength = 0;
            int currentLinesAmount = 0;

            while (textLength > 0) {
                textLength--;
                String randomWord = words[rnd.Next(0, last)];
                currentLineLength += randomWord.Length;
                if (currentLineLength > 80) {
                    randomWord = "\r\n";
                    currentLinesAmount++;
                }
                if (theFirstWordFlag && randomWord.Trim().Length > 1) {
                    randomWord = randomWord.Substring(0, 1).ToUpper() + randomWord.Substring(1);
                    theFirstWordFlag = false;
                }

                String space = " ";
                if (randomWord == "\r\n") {
                    space = "";
                    theFirstWordFlag = true;
                    if (!punctuation.Contains((blaText + " ").Trim().Last().ToString())) {
                        blaText = blaText.Trim() + punctuation[rnd.Next(punctuation.Length)];
                    }
                    int kubik = rnd.Next(1, 4);
                    if (currentLineLength < 10 || kubik == 1) {
                        if (currentLineLength > 2) blaText += " ";
                        continue;
                    }
                    currentLineLength = 0;
                }

                if (currentLinesAmount >= 4 && rnd.Next(1, 2) == 1) {
                    space += "\r\n";
                    currentLinesAmount = 0;
                }

                if (textLength == 0 && !punctuation.Contains((blaText + " ").Trim().Last().ToString())) space = ".";

                    blaText += randomWord + space;
            }
            return blaText;
        }
    }
}
