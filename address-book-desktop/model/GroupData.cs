using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address_book_desktop
{
    public class GroupData : IComparable<GroupData>, IEquatable<GroupData>
    {
        //private string name;

        public GroupData(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int CompareTo(GroupData other)
        {
            return this.Name.CompareTo(other.Name);
        }

        public bool Equals(GroupData other)
        {
            return this.Name.Equals(other.Name);
        }
    }
}
