using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace GDB.Vinn.DataWarehouse.DataSets.ComplexTypes
{
    [Owned]
    public class ReferenceValueString
    {
        [MaxLength(64)]
        public string Source { get; set; }
        [MaxLength(256)]
        public string Value { get; set; }
    }
}