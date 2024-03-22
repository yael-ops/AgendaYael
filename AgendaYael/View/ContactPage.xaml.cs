using AgendaYael.ModelEF;
using AgendaYael.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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


namespace AgendaYael.View
{
    /// <summary>
    /// Logique d'interaction pour AjouterContact.xaml
    /// </summary>
    public partial class ContactPage : UserControl
    {
        public event EventHandler GoToView_changementRequested;

        DAOContacts dAOContacts;
        public ContactPage()
        {
            InitializeComponent();
            dAOContacts= new DAOContacts();
            DG_Contacte.ItemsSource=dAOContacts.GetContactes();

        }
     
        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            AjouterContactPage ajouterContactPage = new AjouterContactPage();
            ajouterContactPage.Show();




        }

        private void Retirer_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = DG_Contacte.SelectedItem as Contact;
            dAOContacts.DeleteContacte(contact.ContactId);
            DG_Contacte.ItemsSource= dAOContacts.GetContactes();
           

        }

        private void modifier_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = DG_Contacte.SelectedItem as Contact;
            dAOContacts.UpdateContacte(contact);
            DG_Contacte.ItemsSource = dAOContacts.GetContactes();
        }

        private void Rechercher_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact();
            DG_Contacte.ItemsSource = dAOContacts.Cherchercontactparnom(TBrechercher.Text);
        }

        private void Tous_Click(object sender, RoutedEventArgs e)
        {
            // qaund je clique je veux afficher tous les contacts
            DG_Contacte.ItemsSource = dAOContacts.GetContactes();
        }

        private void Amis_Click(object sender, RoutedEventArgs e)
        {
            // quand je clique je veux afficher les amis
            DG_Contacte.ItemsSource = dAOContacts.ChercherContacteParStatut("Amis");
        }

        private void Famille_Click(object sender, RoutedEventArgs e)
        {
            // quand je clique je veux afficher la famille
            DG_Contacte.ItemsSource = dAOContacts.ChercherContacteParStatut("Famille");
        }

        private void Buisness_Click(object sender, RoutedEventArgs e)
        {
            // quand je clique je veux afficher les contacts de buisness
            DG_Contacte.ItemsSource = dAOContacts.ChercherContacteParStatut("Buisness");
        }
    }
}
