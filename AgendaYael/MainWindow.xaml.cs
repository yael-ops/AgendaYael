using AgendaYael.Service;
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

namespace AgendaYael
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        private DAOContacts dAOContacts;
        public MainWindow()
        {
            
            InitializeComponent();

            dAOContacts = new DAOContacts();
           //var toto =  dAOContacts.GetAllcontacts();
       
            
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
