using System.ComponentModel;

namespace OCALIPTUS.Domain.Enums;

public enum EntityStatus
{
    [Description("Bekliyor")]
    Waiting = 1,
    [Description("İşlem Yapılıyor")]
    InProgress,
    [Description("Arşivlenmiş")]
    Archived
}