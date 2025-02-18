namespace Topic_4___User_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, firstName, lastName, userName, storeItems;
            int age, ID, grade;
            double mone, average,num1, num2, num3, cost1, cost2;

            //Console.WriteLine("Part 1: ");
            //Console.WriteLine();
            //Console.WriteLine("Hello. Whats is your name?");
            //name = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Hi " + name + "!"+ " How old are you?");
            //age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("So you are " + age +", eh That's not old at all!");
            //Console.WriteLine() ;
            //Console.WriteLine("How much did you make, " + name + "?") ;
            //money = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");
            //Console.WriteLine(money.ToString("C") + "!" + " I hope that's per hour and not per year!");

            //Console.ReadLine();

            //Console.WriteLine("Part 2: ");
            //Console.WriteLine();
            //Console.WriteLine("PLease enter the following information so I can sell it for a profit!");
            //Console.WriteLine();
            //Console.WriteLine("First Name: ");
            //firstName = Console.ReadLine();
            //Console.WriteLine("Last Name: ");
            //lastName = Console.ReadLine();
            //Console.WriteLine("Grade (9-12): ");
            //grade = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Student ID: ");
            //ID = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Average: ");
            //average = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Your Information: ");
            //Console.WriteLine("Login: ");
            //userName = Console.ReadLine();
            //Console.WriteLine("ID: " + ID);
            //Console.WriteLine("Name: " + lastName + ", " + firstName);
            //Console.WriteLine("Average: " + average);
            //Console.WriteLine("Grade: " + grade);

            //Console.ReadLine();


            //Console.WriteLine("Part 3: ");
            //Console.WriteLine("Hello. What is your name? ");
            //name = Console.ReadLine();
            //Console.WriteLine("Hi, " + name + " How old are you? ");
            //age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Did you know that in five years you will be " + (age + 5) + " years old?");
            //Console.WriteLine("And five years ago you were " + age + "!" + " Inmagin that!" );

            //Console.WriteLine("Part 4: ");
            //Console.WriteLine("Pick three numbers.");
            //num1 = Convert.ToDouble(Console.ReadLine());
            //num2 =Convert.ToDouble(Console.ReadLine());
            //num3= Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("The ruslts are " +(num1 + num2 + num3 /2));

            //Console.ReadLine();

            Console.WriteLine("Part 5: ");
            Console.WriteLine();
            Console.WriteLine("Sales Receipt");
            Console.WriteLine();
            Console.WriteLine("Item #1: ");
            storeItems = Console.ReadLine();
            Console.WriteLine("Price: ");
            cost1 = Convert.ToDouble(Console.ReadLine());
            //cost1.ToString("C");
            Console.WriteLine("Item #2: ");
            storeItems = Console.ReadLine();
            Console.WriteLine("Price: ");
            cost2 = Convert.ToDouble(Console.ReadLine());
            //cost2.ToString("C");
            Console.WriteLine("=====================");
            Console.WriteLine("Total: ");
            Console.WriteLine((cost1 + cost2).ToString("C"));
        }
    }
}
