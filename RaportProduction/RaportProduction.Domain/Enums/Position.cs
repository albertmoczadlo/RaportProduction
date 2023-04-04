
using System.ComponentModel.DataAnnotations;

namespace RaportProduction.Domain.Enums;

public enum Position
{
    [Display(Name = "Kierownik")]
    Manager,
    [Display(Name = "Kierownik zmiany")]
    ShiftManager,
    [Display(Name = "Operator")]
    Operator
}
