using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDCHelloWorld
{
    internal class Father : Animal, LivingBeing
    {
        /*
         modificadores de acceso / access modifiers
            public - todos pueden acceder
            private - solo la clase accede
            internal - solo al namespace / proyecto
            protected - clase y lo heredado
            protected internal - solo al namespace y heredado
            private protected - solo a clases anidadas que hereden de la clase
         */

        private string name, nationality, skinColor;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public string SkinColor { get => skinColor; set => skinColor = value; }
        public int Age { get => age; set => age = value; }

        public Father() { }

        public Father(string name, string nationality, string skinColor, int age)
        {
            this.name = name;
            this.nationality = nationality;
            this.skinColor = skinColor;
            this.age = age;
        }

        public void Walk()
        {
            Console.WriteLine("I'm walking");
        }

        public void Eat(string food = "absolutely nothing")
        {
            Console.WriteLine($"I'm eating {food}");
        }

        public void Greet(string otherPersonsName)
        {
            Console.WriteLine($"Hello {otherPersonsName}. My name is {this.name}, I'm {this.age} years old, I'm {this.nationality}.");
        }

        public void Swim()
        {
            throw new NotImplementedException();

            Console.WriteLine("Estoy nadando de crol");
        }

        public void Breath()
        {
            throw new NotImplementedException();

            Console.WriteLine("I'm Breathing");
        }
    }
}
