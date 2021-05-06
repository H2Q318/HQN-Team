using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.DTO
{
    public class CBBItem
    {
        public override string ToString()
        {
            return this.Text;
        }
        public string Value { get; set; }
        public string Text { get; set; }
    }
}
