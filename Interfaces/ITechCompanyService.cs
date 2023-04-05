using Sabio.Models;
using Models.Domain.TechCompanies;
using Sabio.Models.Requests.TechCompany;
using System.Collections.Generic;

namespace Sabio.Services.Interfaces
{
    public interface ITechCompanyService
    {
        public Paged<TechCompany> Pagination(int pageIndex, int pageSize);

        public Paged<TechCompany> SearchPaginated(int pageIndex, int pageSize, string query);

        public TechCompany Get(int id);

        public List<TechCompany> GetAll();

        public void Delete(int id);

        public int Add(TechCompanyAddRequest request, int userId);

        public void Update(TechCompanyUpdateRequest request, int userId);
    }
}