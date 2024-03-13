using AgendaYael.ModelEF;
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
    /// Logique d'interaction pour View_changement.xaml
    /// </summary>
    public partial class View_changement : UserControl
    {
        public View_changement()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Contact contact = new Contact();
            contact.Prenom = TBprenom.Text;
            contact.Nom = TBnom.Text;
            contact.DateDeNaissance= TBdate_de_naissance.Text;
           
            contact.EMail= TBemail.Text;
            using (var context = new DbagendaContext())
            {
                context.Contacts.Add(contact);
                context.SaveChanges();
            }

            MessageBox.Show("Contact ajouté");

        
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this)?.Close();
        }
    }
}
