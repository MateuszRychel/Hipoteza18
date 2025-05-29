namespace Hipoteza18
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Alg(object sender, EventArgs e)
        {
            string word1 = wyraz1.Text;
            string word2 = wyraz2.Text;

            word1 = word1.ToLower();
            word2 = word2.ToLower();

            word1 = System.Text.RegularExpressions.Regex.Replace(word1, @"[^a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]", "");
            word2 = System.Text.RegularExpressions.Regex.Replace(word2, @"[^a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]", "");


            char[] charsToTrim = { '*', ' ', '\'' };
            word1 = word1.Replace("*", "").Replace("'", "").Trim();
            word2 = word2.Replace("*", "").Replace("'", "").Trim();


            char[] arr1 = word1.ToCharArray();
            char[] arr2 = word2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            word1 = new string(arr1);
            word2 = new string(arr2);

            if (word1 == word2)
            {
                wynik.Text = "True";
                SemanticScreenReader.Announce(wynik.Text);
            }
            else
            {
                wynik.Text = "False";
                SemanticScreenReader.Announce(wynik.Text);
            }
            
        }
    }

}