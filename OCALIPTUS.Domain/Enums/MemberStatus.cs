using System.ComponentModel;

namespace OCALIPTUS.Domain.Enums;

public enum MemberStatus
{
    [Description("Onay Bekliyor")]
    Waiting = 1,
    [Description("Onaylı Üye")]
    Success,
    [Description("Üyeliği Onaylanmamış")]
    Failed
}