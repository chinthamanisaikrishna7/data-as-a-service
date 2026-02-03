using Daas.Domain.Entities;

using MediatR;
using Daas.Domain.Entities;
using Microsoft.VisualBasic.FileIO;

namespace Daas.Application.Users.Queries;

public class GetPayloadQueryHandlers : IRequestHandler<GetPayloadQuery, ResultModel[]>
{
    public Task<ResultModel[]> Handle(GetPayloadQuery request, CancellationToken cancellationToken)
    {
        var one="";
        var two="";
        var three="";
        var four="";

            one = request.sus[0].fieldType;
            two = request.sus[0].fieldValue;
            three = request.sus[1].fieldType;
            four = request.sus[1].fieldValue;
        


        ResultModel[] P=new ResultModel[3];
        P[0] = new ResultModel();
        P[1] = new ResultModel();
        P[2] = new ResultModel();
        P[0].columnValue = "1";
        P[1].columnValue = "2";
        P[2].columnValue = "3";
        P[0].fieldValue = "Akash";
        P[1].fieldValue = "Krishna";
        P[2].fieldValue = "Mohan";
        
        
        return Task.FromResult(P);

    }
}