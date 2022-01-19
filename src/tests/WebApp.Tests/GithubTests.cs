using System.Collections.Generic;
using Moq;
using WebApp.Core.Models;
using WebApp.Core.Repositories;
using Xunit;

namespace WebApp.Tests;

public class GithubTests
{
    private Mock<IGithubRepository> mockRepo = new Mock<IGithubRepository>();

    [Fact(DisplayName = "Get All Repositories")]
    public void TestGetAllRepositories()
    {
        var repos = new List<Repository>
        {
            new Repository
            {
                Name = "Test",
                Id = 1,
            }
        };

        mockRepo.Setup(x => x.GetRepositories()).ReturnsAsync(repos);

        Assert.NotEmpty(repos);
    }
}