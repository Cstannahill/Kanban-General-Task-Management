using Sabio.Models;
using Models.Domain.Music;
using System.Collections.Generic;

namespace Sabio.Services.Interfaces
{
    public interface IMusicService
    {
        List<Album> GetAll();

        Paged<Album> Pagination(int pageIndex, int pageSize);
    }
}