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
using static System.Runtime.InteropServices.JavaScript.JSType;
using BLL;
using ENTITIS;
namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for TeachersWindow.xaml
    /// </summary>
    public partial class TeachersWindow : Window
    {
        public TeachersWindow()
        {
            DataContext = this;
            functions bl = new functions();
            Teachers = bl.LoadTeachersDetails();
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public List<Teachers> Teachers { get; set; }
    }
}
