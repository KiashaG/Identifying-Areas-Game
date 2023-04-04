using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PROG7312_PART2
{
    /// <summary>
    /// Interaction logic for IdentifyingAreas_Question_One_.xaml
    /// </summary>
    public partial class IdentifyingAreas_Question_One_ : Window
    {
        public IdentifyingAreas_Question_One_()
        {
            InitializeComponent();
            ImageGenerator();
        }

        // Question one is for call numbers to call descriptions

       int score = 0; // score keeping integer

       int Image_Questions; // image keeping integer

        // This function generates random match the column images

        private void ImageGenerator()
        {
            Random random_Image = new Random();
            Image_Questions = random_Image.Next(1, 7);


            // Switch case method 
            // This method was adapted from W3Schools
            // https://www.w3schools.com/cs/cs_switch.php
            // W3Schools
            // Below the image is being imported from the images folder and then assigned the image brush view

            switch (Image_Questions)
            {
                case 1: 
                    Image_Generator.Source = new BitmapImage(new Uri("pack://application:,,,/imageResources/QuestionOne.png"));

                    break;


                case 4:
                    Image_Generator.Source = new BitmapImage(new Uri("pack://application:,,,/imageResources/QuestionTwo.png"));

                    break;


                case 3:
                    Image_Generator.Source = new BitmapImage(new Uri("pack://application:,,,/imageResources/QuestionThree.png"));

                    break;

                case 5:
                    Image_Generator.Source = new BitmapImage(new Uri("pack://application:,,,/imageResources/QuestionTwo.png"));

                    break;


                case 2:
                    Image_Generator.Source = new BitmapImage(new Uri("pack://application:,,,/imageResources/QuestionThree.png"));

                    break;



                case 6:
                    Image_Generator.Source = new BitmapImage(new Uri("pack://application:,,,/imageResources/QuestionOne.png"));

                    break;

            }
        }

        // Contains dictionary and textbox logic
        // This method was adapted from the prescibed textbook c# data structures and alogorithms 
        // https://libraryconnect.iie.ac.za/client/en_US/iie/search/detailnonmodal/ent:$002f$002fSD_ILS$002f0$002fSD_ILS:22013/one?qu=Algorithmus.&qf=SUBJECT%09Subject%09C%23%09C%23&ps=300
        // Marcin Jamro
        private void DewyDecimal()
        {
            List<string> Tries_SuccessandFailed = new List<string>();


            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("000", "B");
            dictionary.Add("100", "A");
            dictionary.Add("200", "F");
            dictionary.Add("300", "D");
            dictionary.Add("400", "K");
            dictionary.Add("500", "J");
            dictionary.Add("600", "I");
            dictionary.Add("700", "H");
            dictionary.Add("800", "T");
            dictionary.Add("900", "U");


            // Textbox logic
            // This method was adapted from GeeksForGeeks
            // https://www.geeksforgeeks.org/string-split-method-in-c-sharp-with-examples/#:~:text=Split(String%5B%5D%2C%20StringSplitOptions)%20Method,%5B%5D%20separator%2C%20StringSplitOptions%20options)%3B
            // GeeksForGeeks

            // This method was adapted from Microsoft docs
            // https://learn.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split
            // Microsoft

            // This method was adapted from StackoverFlow
            // https://stackoverflow.com/questions/8928601/how-can-i-split-a-string-with-a-string-delimiter
            // StackoverFlow
            // DanTheMan
            // https://stackoverflow.com/users/538133/dantheman

            foreach (UIElement pnl in My_StackPanel.Children)
            {
                TextBox textBox = pnl as TextBox;

                foreach (KeyValuePair<string, string> keyValue in dictionary)
                {
                   

                    Char separator = '-';
                    String[] separatingStrings = textBox.Text.Split(separator);

                  // Scrlbl.Content = " Score: " + score; // show the score to the score label. 
                   //score++;


                    // Call number 000
                    dictionary.TryGetValue(dictionary.ElementAt(0).Key, out string StringValue1).ToString();

                    if (separatingStrings[0] == keyValue.Key)
                    {
                        if (separatingStrings[0] == dictionary.ElementAt(0).Key)
                        {

                            if (StringValue1 == separatingStrings[1])
                            {
                              
                                Tries_SuccessandFailed.Add("Call number 000 was accurately matched with call description.");
                                score = score + 1;
                            }
                            else
                            {

                               Tries_SuccessandFailed.Add("Call number 000 was inaccurately matched with call description.");


                            }


                        }


                    }

                    // Call number 100
                    dictionary.TryGetValue(dictionary.ElementAt(1).Key, out string StringValue2).ToString();

                    if (separatingStrings[0] == keyValue.Key)
                    {
                        if (separatingStrings[0] == dictionary.ElementAt(1).Key)
                        {

                            if (StringValue2 == separatingStrings[1])
                            {
                                Tries_SuccessandFailed.Add("Call number 100 was accurately matched with call description.");
                                score = score + 3;
                            }
                            else
                            {

                               Tries_SuccessandFailed.Add("Call number 100 was inaccurately matched with call description.");


                            }


                        }


                    }
                    // Call number 200

                    dictionary.TryGetValue(dictionary.ElementAt(2).Key, out string StringValue3).ToString();

                    if (separatingStrings[0] == keyValue.Key)
                    {
                        if (separatingStrings[0] == dictionary.ElementAt(2).Key)
                        {

                            if (StringValue3 == separatingStrings[1])
                            {
                                Tries_SuccessandFailed.Add("Call number 200 was accurately matched with call description.");
                                score = score + 3;
                            }
                            else
                            {

                               Tries_SuccessandFailed.Add("Call number 200 was inaccurately matched with call description.");


                            }


                        }


                    }

                    // Call number 300
                    dictionary.TryGetValue(dictionary.ElementAt(3).Key, out string StringValue4).ToString();

                    if (separatingStrings[0] == keyValue.Key)
                    {
                        if (separatingStrings[0] == dictionary.ElementAt(3).Key)
                        {

                            if (StringValue4 == separatingStrings[1])
                            {
                                Tries_SuccessandFailed.Add("Call number 300 was accurately matched with call description.");
                                score = score + 3;
                            }
                            else
                            {

                               Tries_SuccessandFailed.Add("Call number 300 was inaccurately matched with call description.");


                            }


                        }


                    }

                    // Call number 400

                    dictionary.TryGetValue(dictionary.ElementAt(4).Key, out string StringValue5).ToString();

                    if (separatingStrings[0] == keyValue.Key)
                    {
                        if (separatingStrings[0] == dictionary.ElementAt(4).Key)
                        {

                            if (StringValue5 == separatingStrings[1])
                            {
                                Tries_SuccessandFailed.Add("Call number 400 was accurately matched with call description.");
                                score = score + 1;
                            }
                            else
                            {

                               Tries_SuccessandFailed.Add("Call number 400 was inaccurately matched with call description.");


                            }


                        }


                    }

                    // Call number 500 onwards
                    dictionary.TryGetValue(dictionary.ElementAt(5).Key, out string StringValue6).ToString();

                    if (separatingStrings[0] == keyValue.Key)
                    {
                        if (separatingStrings[0] == dictionary.ElementAt(5).Key)
                        {

                            if (StringValue6 == separatingStrings[1])
                            {
                                Tries_SuccessandFailed.Add("Call number 500 was accurately matched with call description.");
                                score = score + 3;
                                
                            }
                            else
                            {

                                Tries_SuccessandFailed.Add("Call number 500 was inaccurately matched with call description.");


                            }


                        }


                    }

                    // Call number 600
                    dictionary.TryGetValue(dictionary.ElementAt(6).Key, out string StringValue7).ToString();

                    if (separatingStrings[0] == keyValue.Key)
                    {
                        if (separatingStrings[0] == dictionary.ElementAt(6).Key)
                        {

                            if (StringValue7 == separatingStrings[1])
                            {
                                Tries_SuccessandFailed.Add("Call number 600 was accurately matched with call description.");
                                score = score + 3;
                                
                            }
                            else
                            {

                                Tries_SuccessandFailed.Add("Call number 600 was inaccurately matched with call description.");


                            }


                        }


                    }

                    // Call number 700
                    dictionary.TryGetValue(dictionary.ElementAt(7).Key, out string StringValue8).ToString();

                    if (separatingStrings[0] == keyValue.Key)
                    {
                        if (separatingStrings[0] == dictionary.ElementAt(7).Key)
                        {

                            if (StringValue8 == separatingStrings[1])
                            {
                                Tries_SuccessandFailed.Add("Call number 700 was accurately matched with call description.");
                               score = score + 3;
                                
                            }
                            else
                            {

                                Tries_SuccessandFailed.Add("Call number 700 was inaccurately matched with call description.");


                            }


                        }


                    }

                    // Call number 800
                    dictionary.TryGetValue(dictionary.ElementAt(8).Key, out string StringValue9).ToString();

                    if (separatingStrings[0] == keyValue.Key)
                    {
                        if (separatingStrings[0] == dictionary.ElementAt(8).Key)
                        {

                            if (StringValue9 == separatingStrings[1])
                            {
                                Tries_SuccessandFailed.Add("Call number 800 was accurately matched with call description.");
                                score = score + 3;
                                
                            }
                            else
                            {

                                Tries_SuccessandFailed.Add("Call number 800 was inaccurately matched with call description.");


                            }


                        }


                    }


                    // Call number 900
                    dictionary.TryGetValue(dictionary.ElementAt(9).Key, out string StringValue10).ToString();

                    if (separatingStrings[0] == keyValue.Key)
                    {
                        if (separatingStrings[0] == dictionary.ElementAt(9).Key)
                        {

                            if (StringValue10 == separatingStrings[1])
                            {
                                Tries_SuccessandFailed.Add("Call number 900 was accurately matched with call description.");
                                score = score + 1;
                               // score++;
                                
                            }
                            else
                            {

                                Tries_SuccessandFailed.Add("Call number 900 was inaccurately matched with call description.");


                            }


                        }


                    }
                }

            }

            ScorePoint.Text = score.ToString();
            My_Attempts.ItemsSource = Tries_SuccessandFailed;

            // This method was adapted from W3Schools
            // https://www.w3schools.com/cs/cs_conditions.php
            // W3Schools

            // SCORE MESSAGE BOX
            if (score == 10)
            {
                WinMessage("Call numbers and Call descriptions were accurately matched: YOU WIN!!!");
            }
            else
            {
                ErrorLoseMessage("Call numbers and Call descriptions were inaccurately matched: YOU LOSE, review the attempts panel to identify errors.");
            }



        }

        // This method was adapted from c# corner
        // https://www.c-sharpcorner.com/Resources/705/how-to-add-a-button-click-event-handler-in-wpf.aspx
        // Soft Dev
        // https://www.c-sharpcorner.com/members/soft-dev

        // Game button funtionality

        private void Reset(object sender, RoutedEventArgs e)
            {
                // Reset controls
                AnswerA.Text = "";
                AnswerB.Text = "";
                AnswerC.Text = "";
                AnswerD.Text = "";
                ScorePoint.Text = "";
                score = 0;
                AnswerA.Focus();
                My_Attempts.ItemsSource = null;
            }


        // Submit button funtionality

        private void Submit(object sender, RoutedEventArgs e)
            {
                DewyDecimal();

            }

        // Back button funtionality
        private void Back(object sender, RoutedEventArgs e)
            {
                IdentifyingAreas IA = new IdentifyingAreas();
                this.Close();
                IA.Show();
            }



        // Next button funtionality
        private void Next_Question(object sender, RoutedEventArgs e)
        {
          IdentifyingAreas_Question_One_ IAO = new IdentifyingAreas_Question_One_();
            this.Close();
            IAO.Show();
        }


        // change order button funtionality
        private void Change_Order(object sender, RoutedEventArgs e)
        {
            IdentifyingAreas_Question_Two_ IATwo = new IdentifyingAreas_Question_Two_();
            this.Close();
            IATwo.Show();
        }

        // This method was adapted from WPF Tutorial 
        // https://wpf-tutorial.com/dialogs/the-messagebox/
        // WPF Tutorial

        // To display the win message box
        private void WinMessage(string WinMessage)
            {
                MessageBox.Show(WinMessage, "The Dewy decimal Game : Librarian Version ", MessageBoxButton.OK, MessageBoxImage.Information); // show a mesage box with the message that is passed in this function
            }

            // This method was adapted from WPF Tutorial 
            // https://wpf-tutorial.com/dialogs/the-messagebox/
            // WPF Tutorial

            // To display the error message box
            private void ErrorLoseMessage(string ErrorLoseMessage)
            {
                MessageBox.Show(ErrorLoseMessage, "The Dewy decimal Game : Librarian Version ", MessageBoxButton.OK, MessageBoxImage.Error); // show a mesage box with the message that is passed in this function
            }

      
    }

    }

