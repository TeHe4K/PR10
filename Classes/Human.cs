using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Pr10.Classes
{
    public class Human
    {
        public string Name { get; set; }
        public string Img { get; set; }
        public Human(string Name, string Img) 
        {
            this.Name = Name;
            this.Img = Img;
        }

        public abstract void Speak(Label Phrase);
    }
}
