using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using OCALIPTUS.Application.Common.Exceptions;
using OCALIPTUS.Application.Common.Helpers;
using OCALIPTUS.Application.Common.Models;
using OCALIPTUS.Application.CommonValues.Queries.Dtos;
using OCALIPTUS.Domain.Enums;

namespace OCALIPTUS.Application.CommonValues.Queries.GetValues
{
    public class GetValuesQueryHandler : IRequestHandler<GetValuesQuery, BaseResponseModel<List<KeyValueModel>>>
    {
        public async Task<BaseResponseModel<List<KeyValueModel>>> Handle(GetValuesQuery request, CancellationToken cancellationToken)
        {
            List<KeyValueModel> model = new List<KeyValueModel>();
            Type enumType = null;

            if (request.ValueId is < 1 or > 7)
                throw new BadRequestException("Lütfen doğru aralıkta değer giriniz.");

            switch (request.ValueId)
            {
                case 1:
                    enumType = typeof(DepartmentType);
                    break;
                case 2:
                    enumType = typeof(DiagnosisType);
                    break;
                case 3:
                    enumType = typeof(EntityStatus);
                    break;
                case 4:
                    enumType = typeof(Gender);
                    break;
                case 5:
                    enumType = typeof(MedicineFrequency);
                    break;
                case 6:
                    enumType = typeof(MemberStatus);
                    break;
                case 7:
                    enumType = typeof(Nationality);
                    break;
            }

            foreach (var value in Enum.GetValues(enumType!))
            {
                model.Add(new KeyValueModel
                {
                    Key = Convert.ToInt64(value),
                    Value = value.GetDescription()
                });
            }

            return BaseResponseModel<List<KeyValueModel>>.Success(model, "Veri başarıyla getirildi.");
        }
    }
}
