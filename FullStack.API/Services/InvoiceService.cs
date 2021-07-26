using FullStack.API.Helpers;
using FullStack.Data;
using FullStack.Data.Entities;
using FullStack.ViewModels;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStack.API.Services
{
    public interface IInvoiceService
    {
        IEnumerable<InvoiceModel> GetAll();
        InvoiceModel GetById(int id);
        InvoiceForCreationModel CreateInvoice(InvoiceForCreationModel invoice);
        void DeleteInvoice(int id);
        InvoiceItemForUpdateModel UpdateInvoice(InvoiceItem invoiceItem);

    }
    public class InvoiceService: IInvoiceService
    {
        private readonly IFullStackRepository _repo;
        private readonly AppSettings _appSettings;
        public InvoiceService(IFullStackRepository repo, IOptions<AppSettings> appSettings)
        {
            this._repo = repo;
            this._appSettings = appSettings.Value;
        }

        public IEnumerable<InvoiceModel> GetAll()
        {
            var invoiceList = _repo.GetInvoices();
            return invoiceList.Select(u => Map(u));
        }

        public InvoiceModel GetById(int id)
        {
            var invoiceEntity = _repo.GetInvoice(id);
            if (invoiceEntity == null) return null;

            return Map(invoiceEntity);
        }
        public InvoiceForCreationModel CreateInvoice(InvoiceForCreationModel invoice)
        {
            var newInvoice = _repo.CreateInvoice(MapInvoiceForCreation(invoice));
            return MapForNewInvoice(newInvoice);

        }
        public InvoiceItemForUpdateModel UpdateInvoice(InvoiceItem invoiceItem)
        {
            var updatedInvoice = _repo.UpdateInvoiceItem(invoiceItem);
            return MapUpdateInvoiceItem(updatedInvoice);
        }
        public void DeleteInvoice(int id)
        {
            _repo.DeleteInvoice(id);
        }

        private InvoiceModel Map(Invoice invoice)
        {
            var inv = new InvoiceModel();
            return new InvoiceModel
            {
                Id = invoice.Id,
                InvoiceDate = invoice.InvoiceDate,
                InvoiceReferenceNumber = invoice.InvoiceReferenceNumber,
                InvoiceDueDate = invoice.InvoiceDueDate,
                InvoiceItems = inv.InvoiceItems,
                TotalInvoiceAmount = invoice.TotalInvoiceAmount,
            };
        }

        private InvoiceForCreationModel MapForNewInvoice(Invoice invoice)
        {
            var inv = new InvoiceForCreationModel();
            return new InvoiceForCreationModel
            { 
                Id = invoice.Id,
                InvoiceDate = invoice.InvoiceDate,
                InvoiceReferenceNumber = invoice.InvoiceReferenceNumber,
                InvoiceDueDate = invoice.InvoiceDueDate,
                InvoiceItems = inv.InvoiceItems,
                TotalInvoiceAmount = invoice.TotalInvoiceAmount,
            };
        }

        private Invoice MapInvoiceForCreation(InvoiceForCreationModel invoice)
        {
            var inv = new Invoice();
            return new Invoice
            {
                Id = invoice.Id,
                InvoiceDate = invoice.InvoiceDate,
                InvoiceReferenceNumber = invoice.InvoiceReferenceNumber,
                InvoiceDueDate = invoice.InvoiceDueDate,
                InvoiceItems = inv.InvoiceItems,
                TotalInvoiceAmount = invoice.TotalInvoiceAmount,
            };
        }

        private InvoiceItemForUpdateModel MapUpdateInvoiceItem(InvoiceItem invoiceItem)
        {
            return new InvoiceItemForUpdateModel
            {
                HoursWorked = invoiceItem.HoursWorked,
                RatePerHour = invoiceItem.RatePerHour,
                Description = invoiceItem.Description
            };
        }

    }
}
