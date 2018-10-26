using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GwbWebApi.Context;
using GwbWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GwbWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ContactUsController : Controller
    {
        private GwbContext _gwbContext;

        public ContactUsController(GwbContext gwbContext)
        {
            _gwbContext = gwbContext;
        }

        [HttpPost]
        public async Task<ContactUs> Create([FromBody] ContactUs contactUs)
        {
            _gwbContext.ContactUs.Add(contactUs);
            await _gwbContext.SaveChangesAsync();
            return await Task.FromResult<ContactUs>(contactUs);

        }

        [HttpPut("{Id}")]
        public async Task<ContactUs> Edit(Guid Id, [FromBody] ContactUs contactUs)
        {
            if (Id != contactUs.Id)
            {
                throw new Exception("invalid operation");
            }

            _gwbContext.ContactUs.Update(contactUs);
            await _gwbContext.SaveChangesAsync();
            return await Task.FromResult<ContactUs>(contactUs);
        }

        [HttpDelete("{Id}")]
        public async void Delete(Guid Id)
        {
            var contact = _gwbContext.ContactUs.Find(Id);
            contact.IsDeleted = true;
            _gwbContext.ContactUs.Update(contact);
            await _gwbContext.SaveChangesAsync();
        }
    }
}