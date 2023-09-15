using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(NetworkCredential credential);
        void Edit(User userModel);
        void Remove(int id);
        User GetById(int id);
        User GetByEmail(string email);
        IEnumerable<User> GetByAll();
    }
}
