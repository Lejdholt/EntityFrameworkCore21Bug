using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GDB.Vinn.DataWarehouse.DataSets.ComplexTypes
{
    [Owned]
    public class ReferenceValueDateTime
    {
        [MaxLength(64)]
        public string Source { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? Value { get; set; }
    }
}