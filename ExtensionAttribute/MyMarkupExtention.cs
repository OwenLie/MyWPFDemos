using ExtensionAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ExtensionAttribute
{
    class MyMarkupExtention : MarkupExtension
    {
        private string name;
        private int age;
        public MyMarkupExtention(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.name + " is " + this.age + " years old;";
        }
    }
}
