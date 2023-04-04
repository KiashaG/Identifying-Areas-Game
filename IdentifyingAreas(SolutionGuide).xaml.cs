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
    /// Interaction logic for IdentifyingAreas_SolutionGuide_.xaml
    /// </summary>
    public partial class IdentifyingAreas_SolutionGuide_ : Window
    {
        public IdentifyingAreas_SolutionGuide_()
        {
            InitializeComponent();
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            IdentifyingAreas_Question_One_ IAQOne = new IdentifyingAreas_Question_One_();
            this.Close();
            IAQOne.Show();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
           IdentifyingAreas IA = new IdentifyingAreas();
            this.Close();
            IA.Show();
        }
    }
}
