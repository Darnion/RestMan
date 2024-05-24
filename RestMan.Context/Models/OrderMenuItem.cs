using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMan.Context.Models
{
    public class OrderMenuItem : IEquatable<OrderMenuItem>,
                                 ICloneable
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public Order Order { get; set; }
        public long MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
        [Required]
        public int Count { get; set; } = 1;

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as OrderMenuItem);
        }

        public bool Equals(OrderMenuItem other)
        {
            return !(other is null) &&
                   Id == other.Id &&
                   Count == other.Count;
        }

        public override int GetHashCode()
        {
            int hashCode = 1603950996;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Count.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(OrderMenuItem left, OrderMenuItem right)
        {
            return EqualityComparer<OrderMenuItem>.Default.Equals(left, right);
        }

        public static bool operator !=(OrderMenuItem left, OrderMenuItem right)
        {
            return !(left == right);
        }
    }
}
