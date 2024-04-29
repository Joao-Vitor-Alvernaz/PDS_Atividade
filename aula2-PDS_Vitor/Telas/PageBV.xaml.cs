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

namespace aula2_PDS_Vitor.Telas
{
    /// <summary>
    /// Interação lógica para PageBV.xam
    /// </summary>
    public partial class PageBV : Page
    {
        Menu _menu;
        public PageBV(Menu menu)
        {
            InitializeComponent();
            _menu = menu;
        }
    }
}
