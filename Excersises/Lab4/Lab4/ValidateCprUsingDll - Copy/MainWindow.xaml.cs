using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        //must be initialized here since gettype need it
        private CprCheck cprCheck = new CprCheck();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CprCheck.CprError cprErr;
           
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*Til at teste hvorfra assembly'en er loaded kan man bruge reflection
            (Type assType = cprNo.GetType(); 
            assType indeholder nu alt den info vi ønsker) */

            Type assType = cprCheck.GetType();
            //set name
            TextBoxName.Text = assType.Assembly.FullName;
            //get info from name
            AssemblyName assName = assType.Assembly.GetName();
            //set version, location and loaded from
            TextBoxVersion.Text = assName.Version.ToString();
            TextBoxLocation.Text = assType.Assembly.Location;
            TextBoxLoadedGAC.Text = assType.Assembly.GlobalAssemblyCache.ToString();
        }
    }
}
