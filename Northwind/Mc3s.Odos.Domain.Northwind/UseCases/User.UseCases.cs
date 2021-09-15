using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mc3s.Odos.Domain.Northwind
{
    partial class Userx
    {
        public Userx() { }

        public Userx(string name, DateTime registeredAt)
        {
            Name = name;
            Registeredat = registeredAt;
        }
    }
}
