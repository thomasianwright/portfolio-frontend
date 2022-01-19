using Refit;
using WebApp.Core.Models;

namespace WebApp.Core.Repositories;

public interface IGithubRepository
{
    [Headers("Content-Type: application/json")]
    [Get("/users/thomasianwright/repos")]
    public Task<IEnumerable<Repository>> GetRepositories();
}