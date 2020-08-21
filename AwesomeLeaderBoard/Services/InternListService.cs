using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AwesomeLeaderBoard.Services
{
public class FakeService : ILeaderboardService
{
    private readonly ApplicationDbContext _context;
    public TodoItemService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<TodoItem[]> GetIncompleteItemsAsync()
{
return await _context.Items
.Where(x => x.IsDone == false)
.ToArrayAsync();
}
    return Task.FromResult(new[] { item1, item2 });
    }
    }
    }