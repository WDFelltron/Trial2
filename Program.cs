using System;
namespace KTurtleTrialModule{
    public class Program{

        public static void Main(string[] args){
        Greeter k1 = new Greeter();
        string u = "User";
        k1.Greet(u);
        }
    }

    public class Greeter{
        public void Greet(string user){
            Console.WriteLine($"Hello {user}!");
        }
    }
}
