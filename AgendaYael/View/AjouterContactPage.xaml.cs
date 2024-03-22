using AgendaYael.ModelEF;
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
using System.Windows.Shapes;

namespace AgendaYael.View
{
    /// <summary>
    /// Logique d'interaction pour ajouterInfos.xaml
    /// </summary>
    public partial class AjouterContactPage : Window
    {
        DAOContacts daoContact;

        public AjouterContactPage()
        {
            InitializeComponent();
            daoContact = new DAOContacts(); // Initialise daoContact
            RemplirComboBoxStatut();
        }
        private void RemplirComboBoxStatut( )
        {
            enumStatut.Items.Add("Amis");
            enumStatut.Items.Add("Famille");
            enumStatut.Items.Add("Buisness");


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact();
            contact.Prenom = TBprenom.Text;
            contact.Nom = TBnom.Text;
            contact.DateDeNaissance = TBdate_de_naissance.Text;

            contact.EMail = TBemail.Text;
            contact.Statut = (string)enumStatut.SelectedItem;

            daoContact.AjouterContact(contact);

            MainWindow mainWindow = new MainWindow();
          
            Window.GetWindow(this)?.Close();
        }

        private void enumStatut_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
