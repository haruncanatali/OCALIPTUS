using System.ComponentModel;

namespace OCALIPTUS.Domain.Enums;

public enum DepartmentType
{
    [Description("Sağlık Personeli")]
    HealthStaff = 1,
    [Description("Teknik")]
    Technical,
    [Description("Yönetim")]
    Management
}