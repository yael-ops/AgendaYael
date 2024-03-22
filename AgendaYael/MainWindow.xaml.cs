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
         DAOToDoList dAOToDoList;
         DAOContacts dAOContacts;
        public MainWindow()
        {
            
            InitializeComponent();
           

            dAOContacts = new DAOContacts();
            dAOToDoList = new DAOToDoList();

            dAOToDoList.GetToDoLists();

           //var toto =  dAOContacts.GetAllcontacts();
           //ghh;f

        }


        

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            changementView.Children.Clear();
            ContactPage contactPage = new ContactPage();
            changementView.Children.Add(contactPage);
        }

        private void Calendar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void To_Do_List_Click(object sender, RoutedEventArgs e)
        {
            // fais en sorte que quand je clique sur ce bouton , la page de to do list s'affiche
            changementView.Children.Clear();
            ToDoListPage toDoListPage = new ToDoListPage();
            changementView.Children.Add(toDoListPage);
        }
    }
}
