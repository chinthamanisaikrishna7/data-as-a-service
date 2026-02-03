using MediatR;
using Daas.Domain.Entities;
using Daas.Application.DTO.RequestDTO;
namespace Daas.Application.Users.Queries;


public record GetPayloadQuery( RequestModel[]  sus ):IRequest<ResultModel[]>;
 
