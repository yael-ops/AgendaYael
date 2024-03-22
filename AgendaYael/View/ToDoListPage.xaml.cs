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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgendaYael.View
{
    public partial class ToDoListPage : UserControl
    {
        private DAOToDoList _daoToDoList; // Instance de votre DAO

        public ToDoListPage()
        {
            InitializeComponent();
            _daoToDoList = new DAOToDoList(); // Initialisation de votre DAO
            RemplirListView();
        }

        private void RemplirListView()
        {
            // Récupérer la liste des tâches depuis le DAO
            List<Todolist> allToDoList = _daoToDoList.GetToDoLists();

            // Associer les données à la ListView
            listViewTasks.ItemsSource = allToDoList;
        }
    }
}
