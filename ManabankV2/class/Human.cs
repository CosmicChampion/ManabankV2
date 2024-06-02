using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manabank
{
    public class Human
    {
        public string Name {  get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public virtual void Show()
        {
            MessageBox.Show("Human");
        }
        public string FullName()
        {
            return this.Name + " " + this.Surname;
        }


    }
}
