using Daas.Application.Common.Interfaces;
using Daas.Domain.Entities;
using MediatR;

namespace Daas.Application.Users.Queries;

//public record GetUsersQuery : IRequest<List<User>>;

public class GetUsersQueryHandler
    : IRequestHandler<GetUsersQuery, List<User>>
{
    private readonly IAppDbContext _context;

    public GetUsersQueryHandler(IAppDbContext context)
    {
        _context = context;
    }

    public Task<List<User>> Handle(
        GetUsersQuery request,
        CancellationToken cancellationToken)
    {
        var users = _context.Users.ToList();
        return Task.FromResult(users);
    }
}
