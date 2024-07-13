using OCALIPTUS.Application.CommonValues.Queries.Dtos;

namespace OCALIPTUS.AdminUI.Models;

public class RegisterCommonValuesModel
{
    public List<KeyValueModel> Genders { get; set; }
    public List<KeyValueModel> Nationalities { get; set; }
}