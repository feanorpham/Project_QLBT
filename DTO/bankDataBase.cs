using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class bankDataBase
    {
        private string shortName;
        private int bin;
        private string name;
        public bankDataBase() { }
        public bankDataBase(string shortName, int bin, string name)
        {
            this.shortName = shortName;
            this.bin = bin;
            this.name = name;
        }
        public string ShortName { get { return shortName; } }
        public int Bin { get { return bin; } }
        public string Name { get { return name; } }
    }
}
