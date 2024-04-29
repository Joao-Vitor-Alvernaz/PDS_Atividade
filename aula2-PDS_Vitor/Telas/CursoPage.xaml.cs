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
    /// Interação lógica para CursoPage.xam
    /// </summary>
    public partial class CursoPage : Page
    {
        Menu _menu;
        public CursoPage(Menu menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _menu.Open_Page("CursoForms");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _menu.Open_Page("CursoForms");
        }
    }
}
