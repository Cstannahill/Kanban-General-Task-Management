using Models.Domain.Users;
using Sabio.Models.Requests.Users;
using System.Collections.Generic;

namespace Sabio.Services
{
    public interface IUserServiceV1
    {
        public void Update(UserUpdateRequest request);

        public User Get(int id);

        public void Delete(int id);

        public int Add(UserAddRequest request, int userId);

        public List<User> GetAll();
    }
}