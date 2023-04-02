using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
