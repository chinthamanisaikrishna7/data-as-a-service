using Daas.Domain.Entities;
using MediatR;

namespace Daas.Application.Users.Queries;

public record GetUsersQuery : IRequest<List<User>>;
