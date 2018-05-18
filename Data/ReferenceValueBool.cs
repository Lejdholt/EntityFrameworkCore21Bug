using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace GDB.Vinn.DataWarehouse.DataSets.ComplexTypes
{
    [Owned]
    public class ReferenceValueBool
    {
        [MaxLength(64)]
        public string Source { get; set; }
        public bool? Value { get; set; }
    }
}