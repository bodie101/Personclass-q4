using System;

namespace personq4
{
    class program 
    {
            
        static void Main(string[] args)
        {
            //Asking if the user to enter person details

            Console.WriteLine("Enter name of new Student below");
            Console.WriteLine();
            Console.WriteLine("First Name: ");
            var fn = Console.ReadLine();

            Console.WriteLine("Last name: ");
            var ln = Console.ReadLine();

            Console .WriteLine("Campus: ");
            var camp = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Creating new person record....");

            Console.WriteLine();

            Console.WriteLine("Enter Year Of birth: dd/mm/yyyy");
            var dob = Console.ReadLine();
            var date = DateTime.Parse(dob); 

            Console.WriteLine();

            //Putting the values from var pep and putting them in PersonInfo

            var pep = new Student(fn, ln, camp, date);
           
            Console.WriteLine(); 
            Console.WriteLine(pep.PersonInfo());

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}


            