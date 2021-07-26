using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FullStack.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullStack.Data
{
    public interface IFullStackRepository
    {
        User GetUser(int id);
        List<User> GetUsers();
        User CreateUser(User user);
        User UpdateUser(User user);
        void DeleteUser(int id);

        //Do the same for all the other entities, Invoices, Invoice Items, etc

        Invoice GetInvoice(int id);
        List<Invoice> GetInvoices();
        Invoice CreateInvoice(Invoice invoice);
        Invoice UpdateInvoice(Invoice invoice);
        void DeleteInvoice(int id);

        InvoiceItem GetInvoiceItem(int id);
        List<InvoiceItem> GetInvoiceItems();
        InvoiceItem CreateInvoiceItem(InvoiceItem invoiceItem);
        InvoiceItem UpdateInvoiceItem(InvoiceItem invoiceItem);
        void DeleteInvoiceItem(int id);

    }
    public class FullStackRepository: IFullStackRepository
    {
        private readonly FullStackDbContext _ctx;
        private readonly Invoice e;
        private readonly InvoiceItem f;

        public FullStackRepository(FullStackDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
            //return _ctx.Users.ToList();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
            //return _ctx.Users.Find(id);
        }

        public User CreateUser(User user)
        {
            throw new NotImplementedException();

            //_ctx.Users.Add(e);
            //_ctx.SaveChanges();
            //return e;
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();

            //var existing = _ctx.Users.SingleOrDefault(em => em.Id == e.Id);
            //if (existing == null) return null;

            //_ctx.Entry(existing).State = EntityState.Detached;
            //_ctx.Users.Attach(e);
            //_ctx.Entry(e).State = EntityState.Modified;
            //_ctx.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();

            //var entity = _ctx.Users.Find(noteId);
            //_ctx.Users.Remove(entity); //CAREFULL!! here when you copy and paste, change _ctx.Users to the new DBSet
            //_ctx.SaveChanges();
        }

        public List<Invoice> GetInvoices()
        {
            //throw new NotImplementedException();
            return _ctx.Invoices.ToList();
        }

        public Invoice GetInvoice(int id)
        {
            //throw new NotImplementedException();
            return _ctx.Invoices.Find(id);
        }

        public Invoice CreateInvoice(Invoice invoice)
        {
            //throw new NotImplementedException();
            _ctx.Invoices.Add(invoice);
            _ctx.SaveChanges();
            return e;
        }

        public Invoice UpdateInvoice(Invoice invoice)
        {
            //throw new NotImplementedException();

            var existing = _ctx.Invoices.SingleOrDefault(em => em.Id == e.Id);
            if (existing == null) return null;

            _ctx.Entry(existing).State = EntityState.Detached;
            _ctx.Invoices.Attach(e);
            _ctx.Entry(e).State = EntityState.Modified;
            _ctx.SaveChanges();
            return existing;
        }

        public void DeleteInvoice(int id)
        {
            //throw new NotImplementedException();

            var entity = _ctx.Invoices.Find(id);
            _ctx.Invoices.Remove(entity);
            _ctx.SaveChanges();
        }

        public InvoiceItem GetInvoiceItem(int id)
        {
            return _ctx.InvoiceItems.Find(id);
        }

        public List<InvoiceItem> GetInvoiceItems()
        {
            return _ctx.InvoiceItems.ToList();
        }

        public InvoiceItem CreateInvoiceItem(InvoiceItem invoiceItem)
        {
            _ctx.InvoiceItems.Add(f);
            _ctx.SaveChanges();
            return f;
        }

        public InvoiceItem UpdateInvoiceItem(InvoiceItem invoiceItem)
        {
            var existing = _ctx.InvoiceItems.SingleOrDefault(em => em.Id == f.Id);
            if (existing == null) return null;

            _ctx.Entry(existing).State = EntityState.Detached;
            _ctx.InvoiceItems.Attach(f);
            _ctx.Entry(f).State = EntityState.Modified;
            _ctx.SaveChanges();
            return existing;
        }

        public void DeleteInvoiceItem(int id)
        {
            var entity = _ctx.InvoiceItems.Find(id);
            _ctx.InvoiceItems.Remove(entity);
            _ctx.SaveChanges();
        }
    }
}
