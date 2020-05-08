using System;
using csharppractice.Math;

namespace csharppractice {

    // public enum ShippingMethod {
    //     RegularAirMail = 1,
    //     RegisteredAirMail = 2,
    //     Express = 3
    // }

    // public class Person {
    //     public int Age;
    // }

    class Program {
        static void Main (string[] args) {

        //     var number = 1;
        //     Increment (number);
        //     System.Console.WriteLine (number); //1

        //     var person = new Person () { Age = 20 };
        //     MakeOld (person);
        //     System.Console.WriteLine (person.Age);
        // }

        // public static void Increment (int number) {
        //     number += 10;
        // }

        // public static void MakeOld (Person person) {
        //     person.Age += 10;
        // }

        //----------------------------------------------------
        //    var a = 10;
        //    var b = a;
        //    b++;
        //    System.Console.WriteLine(string.Format("a: {0}, b: {1}", a , b));

        //     var array1 = new int[3] {1, 2, 3};
        //     var array2 = array1;
        //     array2[0] = 0;
        //     System.Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

        // }

        //--------------------------------------------------------------
        //     var method = ShippingMethod.Express;
        //     System.Console.WriteLine ((int) method);

        //     var methodId = 3;
        //     System.Console.WriteLine ((ShippingMethod) methodId);
        //     //outputs Express

        //     System.Console.WriteLine(method.ToString());

        //     var methodName = "Express";

        //    var ShippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
        // }

        //---------------------------------------------------------
        //     var firstName = "Mosh";
        //     var lastName = "iaja";

        //     var fullName = firstName + " " + lastName;

        //     var myFullName = string.Format ("my name is {0} {1}", firstName, lastName);

        //     var names = new string[3] { "eje", "john", "julia" };
        //     var formattedNames = string.Join (", ", names);
        //     System.Console.WriteLine (formattedNames);
        //     System.Console.WriteLine (myFullName);

        // }
        //     var numbers = new int[3];
        //     numbers[0] = 1;
        //     numbers[1] = 5;
        //     numbers[2] = 7;

        //     System.Console.WriteLine (numbers[0]);
        //     System.Console.WriteLine (numbers[1]);
        //     System.Console.WriteLine (numbers[2]);
        //     System.Console.WriteLine (numbers[2] + numbers[1]);

        //     var flags = new bool[3];
        //     flags[0] = true;

        //     System.Console.WriteLine (flags[0]); //true
        //     System.Console.WriteLine (flags[1]); //false
        //     System.Console.WriteLine (flags[2]); //false

        // }

        //-----------------------------------------------------------
        // var john = new Person();
        // john.FirstName = "john";
        // john.LastName = "Smitch";
        // john.Introduce();

        // Calculator calculator = new Calculator();
        // var result = calculator.add(1, 2);
        // System.Console.WriteLine(result);
        // }

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