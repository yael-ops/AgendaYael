using AgendaYael.ModelEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AgendaYael.View;
using System.Diagnostics.Contracts;

namespace AgendaYael.Service
{
    public class DAOContacts
    {
        DbagendaContext _dbContext;


        public void AjouterContact(Contact contact)
        {
            using (_dbContext = new DbagendaContext())
            {
                // Ajouter le contact à la base de données
                _dbContext.Contacts.Add(contact);

                // Enregistrer les modifications dans la base de données
                _dbContext.SaveChanges();

            }


           
        }
        public IEnumerable<Contact> GetContactes()
        {
            using (_dbContext = new DbagendaContext())
            {
                var allcontact = _dbContext.Contacts.ToList();
                return allcontact;

            }


        }

        public void DeleteContacte(int id)
        {
            using (_dbContext = new DbagendaContext())
            {
                var contacte = _dbContext.Contacts.Find(id);
                _dbContext.Contacts.Remove(contacte);
                _dbContext.SaveChanges();
            }
        }
        public void UpdateContacte(Contact contact)
        {
            using (var context = new DbagendaContext())
            {
                context.Contacts.Update(contact);
                context.SaveChanges();
            }
        }

   
        public IEnumerable<Contact> ChercherContacteParNom(string nom)
        {
            using (var context = new DbagendaContext())
            {
                return context.Contacts.Where(c => c.Nom.Contains(nom)).ToList();
            }
        }


        public bool checkDatabaseExist()
        {

            using (var context = new DbagendaContext())
            {
                return context.Database.CanConnect();
            }
        }

        public IEnumerable<Contact> Cherchercontactparnom(string nom)
        {
            using(var context = new DbagendaContext())
            {
                return context.Contacts.Where(c=>c.Nom.Contains(nom)).ToList();
            }
        }

        //creer une methode qui cherche les contacte par statut 
        public IEnumerable<Contact> ChercherContacteParStatut(string statut)
        {
            using (var context = new DbagendaContext())
            {
                return context.Contacts.Where(c => c.Statut.Contains(statut)).ToList();
            }
        }

    }


}

