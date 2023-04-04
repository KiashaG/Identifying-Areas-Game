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
    /// Interaction logic for IdentifyingAreas.xaml
    /// </summary>
    public partial class IdentifyingAreas : Window
    {
        public IdentifyingAreas()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            this.Close();
            MW.Show();
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            IdentifyingAreas_Question_One_ IAQOne = new IdentifyingAreas_Question_One_();
            this.Close();
            IAQOne.Show();
        }

        private void Solution_Guide(object sender, RoutedEventArgs e)
        {
           IdentifyingAreas_SolutionGuide_ IASG = new IdentifyingAreas_SolutionGuide_();
           this.Close();
           IASG.Show();
        }

        //private void Question_Three(object sender, RoutedEventArgs e)
        //{
        //    IdentifyingAreas_Question_Three_ IAQThree= new IdentifyingAreas_Question_Three_();
        //    this.Close();
        //    IAQThree.Show();
        //}
    }
}
