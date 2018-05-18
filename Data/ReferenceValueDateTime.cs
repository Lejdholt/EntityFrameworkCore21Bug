using System;

namespace GDB.Vinn.DataWarehouse.DataSets.ComplexTypes
{
    public class ReferenceValueDateTime
    {
        public string Source { get; set; }
        public DateTime? Value { get; set; }

        protected bool Equals(ReferenceValueDateTime other)
        {
            return string.Equals(Source, other.Source) && Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((ReferenceValueDateTime) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Source != null ? Source.GetHashCode() : 0) * 397) ^ Value.GetHashCode();
            }
        }
    }
}