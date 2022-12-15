using Repositories.Realizations;
using Streetcode.BLL.Interfaces.Transactions;
using StreetCode.DAL.Repositories.Interfaces.Base;

namespace Streetcode.BLL.Services.Transactions;

public class TransactLinksService : ITransactLinksService
{
    private readonly IRepositoryWrapper _repositoryWrapper;
    public TransactLinksService(IRepositoryWrapper repositoryWrapper)
    {
        _repositoryWrapper = repositoryWrapper;
    }

    public string GetTransactLinkAsync()
    {
        return _repositoryWrapper.TransactLinksRepository.GetTransactLinkAsync();
        // TODO implement here
    }
}