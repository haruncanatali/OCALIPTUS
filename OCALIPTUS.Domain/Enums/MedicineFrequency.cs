using System.ComponentModel;

namespace OCALIPTUS.Domain.Enums;

public enum MedicineFrequency
{
    [Description("Sabah")]
    Morning = 1,
    [Description("Öğle")]
    Afternoon,
    [Description("Akşam")]
    Evening,
    [Description("Gece")]
    Night,
    [Description("Sabah ve Öğle")]
    MorningAfternoon,
    [Description("Sabah ve Akşam")]
    MorningEvening,
    [Description("Sabah ve Gece")]
    MorningNight,
    [Description("Öğle ve Akşam")]
    AfternoonEvening,
    [Description("Öğle ve Gece")]
    AfternoonNight,
    [Description("Akşam ve Gece")]
    EveningNight,
    [Description("Sabah, Öğle ve Akşam")]
    MorningAfternoonEvening,
    [Description("Sabah, Öğle ve Gece")]
    MorningAfternoonNight,
    [Description("Sabah, Akşam ve Gece")]
    MorningEveningNight,
    [Description("Öğle, Akşam ve Gece")]
    AfternoonEveningNight,
    [Description("Sabah, Öğle, Akşam ve Gece")]
    MorningAfternoonEveningNight
}