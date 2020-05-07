using System;

namespace csharppractice {

    public class Person {

        public string FirstName;
        public string LastName;

        public void Introduce () {
            System.Console.WriteLine ("my name is " + FirstName + " " + LastName);

        }
    }

    class Program {
        static void Main (string[] args) {

            var john = new Person ();
            john.FirstName = "john";
            john.LastName = "Smitch";
            john.Introduce ();

        }

        //--------------------------------------------------
        // var a = 1;
        // var b = 2;
        // var c = 3;

        // System.Console.WriteLine(c > b || c == a);

        //---------------------------------------------

        // int num = 22;
        // int num1 = 5;

        // System.Console.WriteLine(num % num1);
        // System.Console.WriteLine(++num);

        //--------------------------------------------------------
        // try
        // {
        //     string str = "true";
        //     bool b = Convert.ToBoolean(str);
        //     System.Console.WriteLine(b);
        // }
        // catch (Exception)
        // {

        //     System.Console.WriteLine("couldnt be converted");
        // }

        // try
        // {
        //     var number = 100;
        //     byte b = Convert.ToByte(number);
        //     Console.WriteLine(b);
        // }
        // catch (Exception)
        // {

        //     Console.WriteLine("couldnt be converted to a byte");
        // }

        // var number = "123";
        // int i = Convert.ToInt32(number);
        // System.Console.WriteLine(i);

        //   int i = 1000;
        //   byte b = (byte) i;
        //   Console.WriteLine(b);

        // }

    }
}