using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining.BaseFunctions
{
    public class SingleInheritanceChild : SingleInheritanceParent
    {
        public void Bark()
        {
            Console.WriteLine("barking...");
        }
    }
}
