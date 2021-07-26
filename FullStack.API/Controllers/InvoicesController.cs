using FullStack.API.Services;
using FullStack.Data.Entities;
using FullStack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoicesController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var invoices = _invoiceService.GetAll();
            return Ok(invoices);
        }

        [HttpGet("{id}", Name ="GetInvoice")]
        public IActionResult GetInvoice(int id)
        {
            var invoice = _invoiceService.GetById(id);
            if (invoice == null) return NotFound();

            return Ok(invoice);
        }
        [HttpPost]
        public IActionResult PostInvoice(InvoiceForCreationModel invoice)
        {
            var newInvoice = _invoiceService.CreateInvoice(invoice);
            return CreatedAtRoute("GetInvoice",
                new { id = newInvoice.Id },
                newInvoice);
        }
        [HttpPut("{id}")]
        public IActionResult PutInvoice(InvoiceItemForUpdateModel invoiceItem)
        {
            var updatedInvoiceItem = _invoiceService.UpdateInvoice(Map(invoiceItem));
            return Ok(updatedInvoiceItem);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteInvoice(int id)
        {
            if (_invoiceService.GetById(id) == null) return NotFound();

            _invoiceService.DeleteInvoice(id);
            return NoContent();
        }
        private InvoiceItem Map(InvoiceItemForUpdateModel invoiceItem)
        {
            return new InvoiceItem
            {
                HoursWorked = invoiceItem.HoursWorked,
                RatePerHour = invoiceItem.RatePerHour,
                Description = invoiceItem.Description

            };
        }
    }
}
