using System;

namespace EmployeeManagement.Models
{
    internal class StringLengthAttribute : Attribute
    {
        private int v;

        public StringLengthAttribute(int v, int MinimumLength)
        {
            this.v = v;
            this.MinimumLength = MinimumLength;
        }

        public int MinimumLength { get; set; }
    }
}