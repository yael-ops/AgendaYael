using AgendaYael.ModelEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AgendaYael.View;

namespace AgendaYael.Service
{
    public class DAOContacts
    {
        DbagendaContext _dbContext;


        public void AjouterContact(Contact contact)
        {


            // Ajouter le contact à la base de données
            _dbContext.Contacts.Add(contact);

            // Enregistrer les modifications dans la base de données
            _dbContext.SaveChanges();
        }
        public IEnumerable<Contact> GetContactes()
        {
            using (DbagendaContext _dbagendaContext = new DbagendaContext())
            {
                var allcontact = _dbagendaContext.Contacts.ToList();
                return allcontact;

            }


        }

        public void DeleteContacte(int id)
        {
            using (var context = new DbagendaContext())
            {
                var contacte = context.Contacts.Find(id);
                context.Contacts.Remove(contacte);
                context.SaveChanges();
            }
        }
    }

    
}

