using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GDB.Vinn.DataWarehouse.DataSets.ComplexTypes
{
    [Owned]
    public class ReferenceValueDouble 
    {
        [MaxLength(64)]
        public string Source { get; set; }
        [Column(TypeName = "decimal(32,12)")]
        public double? Value { get; set; }
    }
}