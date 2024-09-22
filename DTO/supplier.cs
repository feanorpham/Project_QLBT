using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class supplier
    {
        private string codeSupplier;
        private string nameSupplier;
        public supplier()
        {

        }
        public supplier(string codeSupplier, string nameSupplier)
        {
            this.codeSupplier = codeSupplier;
            this.nameSupplier = nameSupplier;
        }
        public string CodeSupplier { get => codeSupplier; set => codeSupplier = value; }
        public string NameSupplier { get => nameSupplier; set => nameSupplier = value; }
    }
}
