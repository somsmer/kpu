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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CprDLL;

namespace ValidateCprUsingDll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CprCheck.CprError cprErr;
            CprCheck cprCheck = new CprCheck();

            //run text thru DLL
            cprCheck.Check(TextBoxCpr.Text, out cprErr);

            //tjek the error code and set it accordingly
             switch (cprErr)
            {
                case CprCheck.CprError.NoError:
                    TextBlockError.Text = "Valid";
                    break;
                case CprCheck.CprError.FormatError:
                    TextBlockError.Text = "Sorry wrong format";
                    break;
                case CprCheck.CprError.DateError:
                    TextBlockError.Text = "Sorry wrong date";
                    break;
                case CprCheck.CprError.Check11Error:
                    TextBlockError.Text = "Not valid";
                    break;
                default:
                    TextBlockError.Text = "Unknown error";
                    break;
            }
      
        }
    }
}
