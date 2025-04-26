using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_attribute
{
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
    public class ZorunluAlanAttribute : Attribute 
    {
    public string Mesaj { get; }

        public ZorunluAlanAttribute(string mesaj = "Bu alan boş bırakılamaz.")
        {
            Mesaj = mesaj;
        }
    }
}
