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
            userName = Console.ReadLine();
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

         */


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

            Console.ReadKey();
        }
    }
}
