using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace TetstEH.Books
{
    public interface IBookAppService : IApplicationService
    {
        Task CreateBook();
        Task UpdateBook();
        Task GetAllBooks();
    }
}
