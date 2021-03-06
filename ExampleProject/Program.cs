using ExampleProject.XmlSerializerHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SelectChoose a = new SelectChoose();
            var ac = a.Serializer<OptionArray>(a.SelectOption());
        }
    }
}
