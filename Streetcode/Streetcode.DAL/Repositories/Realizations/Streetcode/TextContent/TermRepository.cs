using Streetcode.DAL.Entities.Streetcode.TextContent;
using Repositories.Interfaces;
using Repositories.Realizations;
using Streetcode.DAL.Persistence;
using Streetcode.DAL.Repositories.Interfaces.Streetcode.TextContent;

namespace Streetcode.DAL.Repositories.Realizations.Streetcode.TextContent;

public class TermRepository : RepositoryBase<Term>, ITermRepository
{

    public TermRepository(StreetcodeDbContext _streetcodeDBContext)
    {

    }
    public string GetTermAsync()
    {
        return "GetTermAsync";
    }
}