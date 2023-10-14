using EntityFrameWorkBasicPractice;
using Ropository.Contract;
using Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Impementation
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> _repository;

        public ContactService(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public void AddContact(Contact book)
        {
            _repository.AddAsync(book);
        }

        public void DeleteContact(int id)
        {
           var contact= _repository.GetByIdAsync(id).Result;
            if (contact != null)
            {
                _repository.DeleteAsync(contact);
            }
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _repository.GetAllAsync().Result;
        }

        public async Task<Contact> GetContactById(int id)
        {
            var contact=await _repository.GetByIdAsync(id);
            return contact?? new Contact();
        }

        public void UpdateContact(Contact book)
        {
            _repository.UpdateAsync(book);
        }
    }
}
