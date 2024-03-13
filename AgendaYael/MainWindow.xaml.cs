using AgendaYael.ModelEF;
using AgendaYael.Service;
using AgendaYael.View;
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
         DAOContacts dAOContacts;
        public MainWindow()
        {
            
            InitializeComponent();

            dAOContacts = new DAOContacts();
            DG_Contacte.ItemsSource=dAOContacts.GetContactes();
           //var toto =  dAOContacts.GetAllcontacts();
       //ghh;f
            
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            changementView.Children.Clear();
            View_changement view_Changement = new View_changement();
            changementView.Children.Add(view_Changement);
        }

        private void Retirer_Click(object sender, RoutedEventArgs e)
        {
           Contact contact = DG_Contacte.SelectedItem as Contact;
            dAOContacts.DeleteContacte(contact.ContactId);
            DG_Contacte.ItemsSource = dAOContacts.GetContactes();
        }
    }
}
