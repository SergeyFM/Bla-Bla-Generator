using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppDemo.mod {
    internal class BlaBlaGenerator_Gen2 {

        public const int DEFAULT_NUMBER_OF_SENTENCES = 20;
        public const int MAXIMUM_NUMBER_OF_SENTENCES = 1001;
        private int numberOfSentences = DEFAULT_NUMBER_OF_SENTENCES;

        // list of punctuation marks
        private static readonly String[] punctuation = { ".", ",", "!", "..." };
        // list of the most used words in the English language
        private static readonly String[] top_words =  {
            "the", "be", "to", "of", "and", "a", "in", "that", "have", "I", "it", "for", "not", "on", "with", "he", "as", "you", "do", "at", "this", "but", "his", "by", "from", "they", "we", "say", "her", "she", "or", "an", "will", "my", "one", "all", "would", "there", "their", "what", "so", "up", "out", "if", "about", "who", "get", "which", "go", "me", "when", "make", "can", "like", "time", "no", "just", "him", "know", "take", "people", "into", "year", "your", "good", "some", "could", "them", "see", "other", "than", "then", "now", "look", "only", "come", "its", "over", "think", "also", "back", "after", "use", "two", "how", "our", "work", "first", "well", "way", "even", "new", "want", "because", "any", "these", "give", "day", "most", "us"
        };
        // list of the most popular names in the English language
        private static readonly String[] names = {
            "James", "John", "Robert", "Michael", "William", "David", "Richard", "Charles", "Joseph", "Thomas", "Christopher", "Daniel", "Paul", "Mark", "Donald", "George", "Kenneth", "Steven", "Edward", "Brian", "Ronald", "Anthony", "Kevin", "Jason", "Matthew", "Gary", "Timothy", "Jose", "Larry", "Jeffrey", "Frank", "Scott", "Eric", "Stephen", "Andrew", "Raymond", "Gregory", "Joshua", "Jerry", "Dennis", "Walter", "Patrick", "Peter", "Harold", "Douglas", "Henry", "Carl", "Arthur", "Ryan", "Roger"
        };
        // list of the most popular tourist destinations
        private static readonly String[] cities = {
            "Paris", "London", "Rome", "New York", "Barcelona", "Berlin", "Madrid", "Prague", "Vienna", "Amsterdam", "Brussels", "Budapest", "Warsaw", "Dublin", "Copenhagen", "Stockholm", "Athens", "Edinburgh", "Oslo", "Lisbon", "Reykjavik", "Moscow", "Beijing", "Tokyo", "Hong Kong", "Bangkok", "Singapore", "Sydney", "Melbourne", "Perth", "Auckland", "Cape Town", "Rio de Janeiro", "Buenos Aires", "Santiago", "Mexico City", "Lima", "Bogota", "Caracas", "Belize City", "San Jose", "San Salvador", "Managua", "Panama City", "Havana", "Santo Domingo", "Kingston", "Port-au-Prince", "Nassau", "San Juan", "Bridgetown", "Port of Spain", "Castries", "Kingstown", "Roseau", "Saint George's", "Saint John's", "Basseterre", "Charlotte Amalie", "Willemstad", "Oranjestad" };
        // list of personal pronouns
        private static readonly String[] pronouns = { "I", "you", "we", "they" };
        private static readonly String[] pronouns_s = { "he", "she", "it" };
        // list of miningless inserts
        private static readonly String[] inserts = { "don't know how to put it", "it's like", "whatever", "it's never easy to say", "so to say" };
        // list of verbs
        private static readonly String[] verbs = { "move", "think", "love", "don't like", "see" };
        // list of nouns
        private static readonly String[] nouns = { "dog", "cat", "car", "house", "tree", "flower", "sun", "moon", "star", "planet", "universe", "life", "death", "sun", "book", "phone" };

        // returns a word based on the request
        private static String GetWord(String type) {
            Random rnd = new Random();
            switch (type) {
                case "punctuation":
                    return punctuation[rnd.Next(punctuation.Length)];
                case "top_words":
                    return top_words[rnd.Next(top_words.Length)];
                case "names":
                    return names[rnd.Next(names.Length)];
                case "cities":
                    return cities[rnd.Next(cities.Length)];
                case "pronouns":
                    return pronouns[rnd.Next(pronouns.Length)];
                case "pronouns_s":
                    return pronouns_s[rnd.Next(pronouns_s.Length)];
                case "inserts":
                    return inserts[rnd.Next(inserts.Length)];
                case "verbs":
                    return verbs[rnd.Next(verbs.Length)];
                case "nouns":
                    return nouns[rnd.Next(nouns.Length)];
                default:
                    return "";
            }
        }

        // mark to word request
        private static String MarkToWordRequest(String mark) => mark switch {
            "[P]" => "pronouns",
            "[I]" => "inserts",
            "[V]" => "verbs",
            "[N]" => "nouns",
            "[Z]" => "punctuation",
            _ => ""
        };


        // sentence patterns
        private static readonly String[] sentence_patterns = {
            "[P] [V] the [N].",
            "[P] [V] the [N]!",
            "[P] [I], [V] the [N].",
            "[I] [P] [V] the [N].",
            "[P] [V] the [N], [I] [P] [V] the [N].",
            "[I] [P] [V] the [N]... [V] [P] the [N]."
        };

        public BlaBlaGenerator_Gen2() {

        }

        // randomly add return carrige and new line symbols, or empty space
        private static String RandomNewLine() {
            Random rnd = new Random();
            return rnd.Next(1,4) == 1 ? "\r\n" :
                   rnd.Next(1,12) == 1 ? "\r\n\r\n" : 
                " ";
        }

        public String Generate(int num_sen) {

            // sanity check
            numberOfSentences = LimitNumberOfSenteces(num_sen);
            
            return Generate();
        }

        public int LimitNumberOfSenteces(int num_sen) {
            int numOfSent = 0;
            if (num_sen < 0) numOfSent = DEFAULT_NUMBER_OF_SENTENCES;
            else if (num_sen > MAXIMUM_NUMBER_OF_SENTENCES) numOfSent = MAXIMUM_NUMBER_OF_SENTENCES;
            else numOfSent = num_sen;
            return numOfSent;
        }

        public String Generate() {
            Random rnd = new Random();
            String text = "";
            for (int sentence_number = 0; sentence_number < numberOfSentences; sentence_number++) {
                String sentence = sentence_patterns[rnd.Next(sentence_patterns.Length)];
                String[] words = sentence.Split(' ');
                
                for (int word_number = 0; word_number < words.Length; word_number++) {
                    Console.WriteLine(words[word_number]);
                    String[] block = words[word_number].Split("]");
                    String word,tail;
                    word = block.First() + "]";
                    tail = block.Length > 1 ? block[1] : "";
                    if (word.StartsWith("[") && word.EndsWith("]")) {
                        String word_request = MarkToWordRequest(word);
                        if (word_request != "") {
                            words[word_number] = GetWord(word_request) + tail;
                        }
                    }
                }
                sentence = String.Join(" ", words);
                sentence = sentence.Substring(0, 1).ToUpper() + sentence.Substring(1);
                Console.WriteLine(sentence);
                text += sentence + RandomNewLine();
            }

            return text;
        }

        private static String RemoveAfter(String value, String character) {
            int index = value.IndexOf(character);
            if (index > 0) value = value.Substring(0,index + 1);
            return value;
        }

    }
}
