using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace GDB.Vinn.DataWarehouse.DataSets.ComplexTypes
{
    [Owned]
    public class ReferenceValueInteger
    {
        [MaxLength(64)]
        public string Source { get; set; }
        public int? Value { get; set; }
    }
}