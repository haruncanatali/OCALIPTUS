using MediatR;
using OCALIPTUS.Application.Common.Models;
using OCALIPTUS.Application.CommonValues.Queries.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCALIPTUS.Application.CommonValues.Queries.GetValues
{
    public class GetValuesQuery : IRequest<BaseResponseModel<List<KeyValueModel>>>
    {
        public int ValueId { get; set; }
    }
}
