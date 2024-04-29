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

namespace aula2_PDS_Vitor.Telas
{
    /// <summary>
    /// Lógica interna para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            Loaded += Menu_Loaded;
        }

        public void Open_Page(string menu)
        {
           switch (menu)
            {
                case "EscolaConsulta":
                    framePage.NavigationService.Navigate(new EscolaPage(this));
                    break;

                case "EscolaForms":
                    framePage.NavigationService.Navigate(new CadastrarEscola(this));
                    break;

                case "CursoConsulta":
                    framePage.NavigationService.Navigate(new CursoPage(this));
                    break;

                case "CursoForms":
                    framePage.NavigationService.Navigate(new CadastrarCurso(this));
                    break;

                case "TurmaConsulta":
                    framePage.NavigationService.Navigate(new TurmaPage(this));
                    break;

                case "TurmaForms":
                    framePage.NavigationService.Navigate(new CadastrarTurma(this));
                    break;

                case "AlunoConsulta":
                    framePage.NavigationService.Navigate(new AlunoPage(this));
                    break;

                case "AlunoForms":
                    framePage.NavigationService.Navigate(new CadastrarAluno(this));
                    break;

                case "PageBV":
                    framePage.NavigationService.Navigate(new PageBV(this));
                    break;
            }
        }
        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            //framePage.Source = new Uri("/Telas/EscolaPage.xaml", UriKind.Relative);
            Open_Page("PageBV");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //framePage.Source = new Uri("/Telas/EscolaPage.xaml", UriKind.Relative);
            Open_Page("EscolaConsulta");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //framePage.Source = new Uri("/Telas/CursoPage.xaml", UriKind.Relative);
            Open_Page("CursoConsulta");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //framePage.Source = new Uri("/Telas/TurmaPage.xaml", UriKind.Relative);
            Open_Page("TurmaConsulta");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //framePage.Source = new Uri("/Telas/AlunoPage.xaml", UriKind.Relative);
            Open_Page("AlunoConsulta");
        }
    }
}
