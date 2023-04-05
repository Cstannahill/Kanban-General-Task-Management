using Models.Domain;
using Models.Domain.Users;
using Sabio.Models.Requests.Users;
using System.Threading.Tasks;

namespace Sabio.Services
{
    public interface IUserService
    {
        int Create(UserAddRequest model);

        Task<bool> LogInAsync(string email, string password);

        public User GetCurrent(int userId);
        public void ConfirmUser(string token);
        public void AddToken(string token, int userId, int tokenType);
        Task<bool> LogInTest(string email, string password, int id, string[] roles = null);
    }
}