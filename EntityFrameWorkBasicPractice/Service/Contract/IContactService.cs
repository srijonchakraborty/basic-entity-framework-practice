using EntityFrameWorkBasicPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contract
{
    public interface IContactService
    {
        IEnumerable<Contact> GetAllContacts();
        Task<Contact> GetContactById(int id);
        void AddContact(Contact book);
        void UpdateContact(Contact book);
        void DeleteContact(int id);
    }
}
