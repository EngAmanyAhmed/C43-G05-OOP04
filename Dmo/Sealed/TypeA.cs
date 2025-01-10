using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmo.Sealed
{
    internal class TypeA
    {
        public virtual int A { get; set; }
        public virtual void MyFun()
        {
            Console.WriteLine(value: "My Fun From TypeA");
        }

    }
}
