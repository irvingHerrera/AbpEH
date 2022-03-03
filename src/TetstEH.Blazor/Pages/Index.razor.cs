using System.Threading.Tasks;

namespace TetstEH.Blazor.Pages;

public partial class Index
{
    public Index()
    {

    }

    public async Task CreateBook()
    {
        await BookAppService.CreateBook();
        await BookAppService.GetAllBooks();
    }

    public async Task UpdateBook()
    {
        await BookAppService.UpdateBook();
    }
}
