using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {


            // Variables


            // Data Type VariableName = value;

            // Camel Case 
            /*
            int firstNumber = 10;
            string studentName = "Ali Islam";
            bool isMarried = false;
            string ageInYears = "25";
            decimal salary = 15000.50m;

            // Pascal Case

            double fee = 1600.60d;

            float expenses = 1700.00f;

            decimal Pi = 3.14m;
            */
            // Hungrian Notation


            /*
             
             This 
                is 
                       a multi line comment.
             
             
             
             



            string userName;
            string password;

            Console.WriteLine("Please enter your User Name:");
            userName = Console.ReadLine();.

            Console.WriteLine("Please enter your Password:");
            password = Console.ReadLine();

            // Concatenation
            Console.WriteLine("User Name is :" + userName + " and your password is :" + password);


            // Format Strings

            string studentName;
            string fatherName;
            string gender;
            string rollNumber;

            Console.WriteLine("Please enter Student name :");
            studentName = Console.ReadLine();

            Console.WriteLine("Please enter Father name :");
            fatherName = Console.ReadLine();

            Console.WriteLine("Please enter Gender :");
            gender = Console.ReadLine();

            Console.WriteLine("Please enter Roll Number :");
            rollNumber = Console.ReadLine();


            Console.WriteLine("Student name is {0} and father name is {1}. {0} is {2} and his roll number is {3}.",studentName,fatherName,gender,rollNumber);

             

            Console.WriteLine("Please enter marks of Islam : ");
            int Islam  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter marks of Zeeshan : ");
            int Zeeshan  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter marks of Haider : ");
            int Haider = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter marks of Raouf : ");
            int Raouf = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter marks of Ali : ");
            int Ali = Convert.ToInt32(Console.ReadLine());

            // if islam is at first position
            if (Islam > Zeeshan && Islam > Haider && Islam > Raouf && Islam > Ali)
            {
                Console.WriteLine("Islam is at first position.");

                // Second Position
                if (Zeeshan > Haider && Zeeshan > Raouf && Zeeshan > Ali)
                {
                    Console.WriteLine("Zeeshan is at second position.");

                    // Third Position
                    if(Haider > Raouf && Haider > Ali)
                    {
                        Console.WriteLine("Haider is at third position.");

                        // Fourth | Fifth
                        if (Raouf > Ali)
                        {
                            Console.WriteLine("Raouf is at fourth position.");
                            Console.WriteLine("Ali is at fifth position.");
                        }
                        else
                        {
                            Console.WriteLine("Ali is at fourth position.");
                            Console.WriteLine("Raouf is at fifth position.");
                        }
                    }
                    else if(Raouf > Haider && Raouf > Ali)
                    {
                        Console.WriteLine("Raouf is at third position.");

                        // Fourth | Fifth
                    }
                    else
                    {
                        Console.WriteLine("Ali is at third position.");

                        // Fourth | Fifth
                    }
                }
                else if (Haider > Zeeshan && Haider > Raouf && Haider > Ali)
                {
                    Console.WriteLine("Haider is at second position.");
                }
                else if (Raouf > Haider && Raouf > Zeeshan && Raouf > Ali)
                {
                    Console.WriteLine("Raouf is at second position.");
                }
                else
                {
                    Console.WriteLine("Ali is at second position.");
                }
            }
            else if (Zeeshan > Islam && Zeeshan > Haider && Zeeshan > Raouf && Zeeshan > Ali)
            {
                Console.WriteLine("Zeeshan is at first position.");
            }
            else if (Haider > Islam && Haider > Zeeshan && Haider > Raouf && Haider > Ali)
            {
                Console.WriteLine("Haider is at first Position.");
            }
            else if (Raouf > Islam && Raouf > Haider && Raouf > Zeeshan && Raouf > Ali)
            {
                Console.WriteLine("Raouf is at first Position.");
            }
            else
            {
                Console.WriteLine("Ali is at first Position.");
            }



            // First Position
            if(Islam > Haider && Islam > Zeeshan && Islam > Ali && Islam > Raouf)
            {
                // 1st
                // second position cases
                if(Haider > Zeeshan && Haider > Raouf && Haider > Ali)
                {
                    // 2nd
                    // Third position cases
                    if(Zeeshan > Raouf && Zeeshan > Ali)
                    {
                        // 3rd 
                        // fourth / fifth position cases
                    }
                }
                else if(Zeeshan > Haider && Zeeshan > Raouf && Zeeshan > Ali)
                {
                    // 2nd
                    // third position cases
                    if(Haider > Raouf && Haider > Ali)
                    {
                        // 3rd
                        // 4th / 5th position cases

                    }
                }
            }

            if (Zeeshan > Haider)
            {
                Console.WriteLine("Zeeshan is at Second Position.");
                Console.WriteLine("Haider is at third position.");
            }
            else
            {
                Console.WriteLine("Haider is at Second Position.");
                Console.WriteLine("Zeeshan is at third position.");
            }

            if (Zeeshan > Islam)
            {
                Console.WriteLine("Zeeshan is at Second Position.");
                Console.WriteLine("Islam is at third position.");
            }
            else
            {
                Console.WriteLine("Islam is at Second Position.");
                Console.WriteLine("Zeeshan is at third position.");
            }


            if (Islam > Haider)
            {
                Console.WriteLine("Islam is at Second Position.");
                Console.WriteLine("Haider is at third position.");
            }
            else
            {
                Console.WriteLine("Haider is at Second Position.");
                Console.WriteLine("Islam is at third position.");
            }

 


            // switch

            // vowels aeiou

            Console.WriteLine("Please enter a character ? ");
            string character = Console.ReadLine();

            switch (character)
            {
                case "e":
                case "i":
                case "o":
                case "u":
                case "a":
                    Console.WriteLine("Entered character is vowel.");
                    break;

                default:
                    Console.WriteLine("Entered character is not a vowel.");
                    break;
            }

            Console.WriteLine("Please enter first number ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number .");
            int secondNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Which operation do you want to perform (Press : +,-,*,/,%)");
            string opp = Console.ReadLine();

            switch (opp)
            {
                case "+":
                    Console.WriteLine(firstNumber + secondNumber);
                    break;

                case "-":
                    Console.WriteLine(firstNumber - secondNumber);
                    break;

                case "*":
                    Console.WriteLine(firstNumber * secondNumber);
                    break;

                case "/":
                    Console.WriteLine(firstNumber / secondNumber);
                    break;

                case "%":
                    Console.WriteLine(firstNumber % secondNumber);
                    break;

                default:
                    Console.WriteLine("Invalid operation, please enter a valid operator.");
                    break;
            }

            Console.WriteLine("Please enter first number ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number .");
            int secondNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Which operation do you want to perform (Press : 1 for Sum, 2 For Subtract)");
            int opp = Convert.ToInt32(Console.ReadLine());

            switch (opp)
            {
                case 1:
                    Console.WriteLine(firstNumber + secondNumber);
                    break;

                case 2:
                    Console.WriteLine(firstNumber - secondNumber);
                    break;

                case 3:
                    Console.WriteLine(firstNumber * secondNumber);
                    break;

                case 4:
                    Console.WriteLine(firstNumber / secondNumber);
                    break;

                case 5:
                    Console.WriteLine(firstNumber % secondNumber);
                    break;

                default:
                    Console.WriteLine("Invalid operation, please enter a valid operator.");
                    break;
            }

  
            int Ali, Haider, Zeeshan, Faizan, Raouf;

            Console.WriteLine("Please enter marks of Ali : ");
            Ali = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter marks of Haider : ");
            Haider = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter marks of Zeeshan : ");
            Zeeshan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter marks of Faizan : ");
            Faizan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter marks of Raouf : ");
            Raouf = Convert.ToInt32(Console.ReadLine());


            // int Ali, Haider, Zeeshan, Faizan, Raouf;

            if(Ali > Haider && Ali >Zeeshan && Ali > Faizan && Ali > Raouf)
            {
                Console.WriteLine("Ali is at first Position.");

                // second | third | fourth | fifth

                if(Haider > Zeeshan && Haider > Faizan && Haider > Raouf)
                {
                    Console.WriteLine("Haider is at Second Position.");

                    // third | fourth | fifth

                    if(Zeeshan > Faizan && Zeeshan > Raouf)
                    {
                        Console.WriteLine("Zeeshan is at Third Position.");

                        // fourth | fifth

                        if(Faizan > Raouf)
                        {
                            Console.WriteLine("Faizan is at Fourth Position.");
                            Console.WriteLine("Raouf is at Fifth Position.");
                        }
                        else
                        {
                            Console.WriteLine("Raouf is at Fourth Position.");
                            Console.WriteLine("Faizan is at Fifth Position.");
                        }
                    }
                    else if(Faizan > Zeeshan && Faizan > Raouf)
                    {
                        Console.WriteLine("Faizan is at Third Position.");

                        // Fourth | Fifth
                        if (Zeeshan > Raouf)
                        {
                            Console.WriteLine("Zeeshan is at Fourth Position.");
                            Console.WriteLine("Raouf is at Fifth Position.");
                        }
                        else
                        {
                            Console.WriteLine("Raouf is at Fourth Position.");
                            Console.WriteLine("Zeeshan is at Fifth Position.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Raouf is at Third Position.");

                        // Fourth | Fifth
                        if (Zeeshan > Faizan)
                        {
                            Console.WriteLine("Zeeshan is at Fourth Position.");
                            Console.WriteLine("Faizan is at Fifth Position.");
                        }
                        else
                        {
                            Console.WriteLine("Faizan is at Fourth Position.");
                            Console.WriteLine("Zeeshan is at Fifth Position.");
                        }
                    }

                }
                else if(Zeeshan > Haider && Zeeshan > Faizan && Zeeshan > Raouf)
                {
                    Console.WriteLine("Zeeshan is at Second Position.");


                }
                else if(Faizan > Zeeshan && Faizan > Haider && Faizan > Raouf)
                {
                    Console.WriteLine("Faizan is at Second Position.");

                }
                else
                {
                    Console.WriteLine("Raouf is at Second Position.");

                }
            }
            else if(Haider > Ali && Haider > Zeeshan && Haider > Faizan && Haider > Raouf)
            {
                Console.WriteLine("Haider is at first Position.");
            }
            else if(Zeeshan > Ali && Zeeshan > Haider && Zeeshan > Faizan && Zeeshan > Raouf)
            {
                Console.WriteLine("Zeeshan is at first Position.");
            }
            else if(Faizan > Ali && Faizan > Haider && Faizan > Zeeshan && Faizan > Raouf)
            {
                Console.WriteLine("Faizan is at first Position.");
            }
            else
            {
                Console.WriteLine("Raouf is at first Position.");
            }

            Console.WriteLine("Enter Ali marks");
            int ali = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter khan Marks");
            int khan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amjad marks");
            int amjad = Convert.ToInt32(Console.ReadLine());

            if (ali > khan && ali > amjad)
            {
                Console.Write("Ali is at first position");

                if (khan > amjad)
                { 
                    Console.Write("khan is at second position");
                    Console.WriteLine("Amjad is at third position");
                }
                else
                {
                    Console.WriteLine("Amjad is at second position");
                    Console.WriteLine("khan is at third position");
                }
            }
            else if( khan > ali && khan > amjad)
            {
                Console.WriteLine("khan is at first position");
                if(ali > amjad)
                {
                    Console.WriteLine("ali is at second position");
                    Console.WriteLine("amjad is at third position");
                }
                else
                {
                    Console.WriteLine("amjad is at second position");
                    Console.WriteLine("ali is at third position");
                }

            }
            else
            {
                Console.WriteLine("amjad is at first position");
            }
    
      
            // Iterations (Loops) For Loop, While Loop, Do While Loop, Foreach Loop


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Number : {0}",i);
            }

            
            // Table 2 * 1 = 2   

            Console.WriteLine("Please enter a number to print table ? ");
            int tableNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a limit for table ? ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int index = 1;
            while(index <= limit)
            {
                Console.WriteLine("{0}  x  {1}   =   {2}",tableNumber,index,tableNumber * index);
                index++;
            }

   

            // Table 2 * 1 = 2   

            Console.WriteLine("Please enter a number to print table ? ");
            int tableNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a limit for table ? ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int index = 1;
            do
            {
                Console.WriteLine("{0}  x  {1}   =   {2}", tableNumber, index, tableNumber * index);
                index++;
            }
            while (index <= limit);

            for (int i = 0; i < length; i++)
            {

            }

            while (true)
            {

            }


    
            // indexes = 0,1,2,3,4 0  1  2  3  4
            int[] rollNumbers =  { 45,65,78,96,45};

            Console.WriteLine(rollNumbers[0]);

            Console.WriteLine(rollNumbers.Min());
            Console.WriteLine(rollNumbers.Max());
            Console.WriteLine(rollNumbers.Count());
            Console.WriteLine(rollNumbers.Contains(65));
            Console.WriteLine(rollNumbers.Average());
            Console.WriteLine(rollNumbers.Reverse());
            Console.WriteLine(rollNumbers.Sum());


            string[] employees = new string[10] { "Raouf","Ahmed","Ali","Abdullah","Riaz","Raheem","Razzaq","Ayaan","Muhammad Ahmed","Abid Ali"};


            if(employees.Contains("Abdullahh") && employees.Contains("Raheem"))
            {
                Console.WriteLine("Both brothers are present in the JOB.");
            }
            else
            {
                Console.WriteLine("One / Both of them are not present in the class.");
            }


            for (int i = 0; i < employees.Count(); i++)
            {
                Console.WriteLine("{0} is Present",employees[i]);
            }

            foreach (string employeeName in employees)
            {
                Console.WriteLine("{0} is Present",employeeName);
            }

     

            decimal sum = 0.0m;

            foreach (int item in marks)
            {
                sum = sum + item;
            }

            Console.WriteLine("Sum of marks is {0}",sum);


  
            int[] marks = { 456, 665, 448, 55, 686, 55, 66, 88, 66, 88, 77, 88, 99 };

            int min = marks[0];

            for(int i = 1; i < marks.Count(); i++)
            {
                if (marks[i] < min)
                {
                    min = marks[i];
                }   
            }

            string[] employes = { "zeeshan","haider","ali" };
            Console.WriteLine("Which Employe you want");
            string name = Console.ReadLine();

            if (employes.Contains(name))
            {
                Console.WriteLine("employ found");
            
            }
            else
            {
                Console.WriteLine("employ is not found sorry");
            }

            // Lists
            

            List<int> marks = new List<int>();

            List<decimal> balances = new List<decimal>();
        */

            int[] numbers = new int[5];

            List<string> customers = new List<string>();

            /*
            customers.Add("Ali");
            customers.Add("Adil");
            customers.Add("Ahmed");
            customers.Add("Abdullah");
            customers.Add("Raouf");
            customers.Add("Raza");
          

            Console.WriteLine("How to many customers do you want to store?");
            int totalcustomers = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i<totalcustomers; i++)
            {
                customers.Add(Console.ReadLine());
            }

            Console.WriteLine("Provided List of Customers is below:");

            foreach (string customerName in customers)
            {
                Console.WriteLine(customerName); 
            }


            List<Student> students = new List<Student>();

            Student std1 = new Student();
            std1.Id = 1;
            std1.Name = "Islam";
            std1.AgeInYears = 25;
            std1.IsMarried = false;
            std1.Fee = 20000m;

            Student std2 = new Student();
            std2.Id = 2;
            std2.Name = "Haider";
            std2.AgeInYears = 23;
            std2.IsMarried = false;
            std2.Fee = 20000m;

            Student std3 = new Student();
            std3.Id = 3;
            std3.Name = "Zeeshan";
            std3.AgeInYears = 26;
            std3.IsMarried = true;
            std3.Fee = 20000m;

            students.Add(std1);
            students.Add(std2);
            students.Add(std3);


            foreach (var std in students)
            {
                Console.WriteLine(std.Id);
                Console.WriteLine(std.Name);
                Console.WriteLine(std.AgeInYears);
                Console.WriteLine(std.IsMarried);
                Console.WriteLine(std.Fee);
            }


            List<Student> newStudents = new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    Name = "Raouf",
                    AgeInYears = 25,
                    IsMarried = true,
                    Fee = 20000
                },
                new Student
                {
                    Id = 1,
                    Name = "Raouf",
                    AgeInYears = 25,
                    IsMarried = true,
                    Fee = 20000
                },
                new Student
                {
                    Id = 1,
                    Name = "Raouf",
                    AgeInYears = 25,
                    IsMarried = true,
                    Fee = 20000
                }
            };

    
            

            Console.WriteLine("Maximum: {0}, Minimum: {1}, Total Items: {2}",_numbers.Max(), _numbers.Min(),_numbers.Count());

            _numbers.Sort();

            foreach (int num in _numbers)
            {
                Console.WriteLine(num);
            }

            List<int> _numbers = new List<int>();
            _numbers.Add(63);
            _numbers.Add(36);
            _numbers.Add(50);
            _numbers.Add(51);
            _numbers.Add(52);
            _numbers.Add(53);


            _numbers.Remove(36);

            _numbers.RemoveRange(0, 2);

            foreach (int num in _numbers)
            {
                Console.WriteLine(num);
            }
         */

            Console.WriteLine("Please enter first Number :");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter first Number :");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            string opp = Console.ReadLine();



            MyMath myMath = new MyMath();

            Console.WriteLine("Result {0}",myMath.Caculation(firstNumber,secondNumber,opp));


            Console.ReadKey();
        }
    }
}
