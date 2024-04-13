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
using DAMAGE666.IL_PATIODataSetTableAdapters;
namespace DAMAGE666
{
    public partial class ItalianoMenu : Page
    {
        ITALIAN_MENU_PATIOTableAdapter italia = new ITALIAN_MENU_PATIOTableAdapter();
        public ItalianoMenu()
        {
            InitializeComponent();
            ColourDataGrid.ItemsSource = italia.GetData();
        }
    }
}
      