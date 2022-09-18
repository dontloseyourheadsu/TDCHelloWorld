using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDCHelloWorld
{
    internal class Son : Father
    {
        private bool studies;
        public bool Studies { get => studies; set => studies = value; }

        public Son() : base() {}
        public Son(string name, string nationality, string skinColor, int age, bool studies) 
            : base(name, nationality, skinColor, age) 
        {
            this.studies = studies;
        }

        public void Studying(string subject)
        {
            Console.WriteLine($"I'm learning {subject}.");
        }

        public void Greet(string otherPersonName, string subject)
        {
            string isStudying = this.studies ? "12th grade" : "nothing";
            Console.WriteLine($"Hello {otherPersonName}. I'm {this.SkinColor}. I'm coursing {isStudying}.");

            Studying(subject);
        }

        public void Swim()
        {
            throw new NotImplementedException();
            Console.WriteLine("Nadando");
        }
    }
}
