using System;


namespace csharppractice
{
     public class Person {

        public string FirstName;
        public string LastName;

        public void Introduce () {
            System.Console.WriteLine ("my name is " + FirstName + " " + LastName);

        }
    }
}