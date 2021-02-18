using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "1. Get Rectangle Length\n"
                + "2. Change Rectangle Length\n"
                + "3. Get Rectangle Width\n"
                + "4. Change Rectangle Width\n"
                + "5. Get Rectangle Perimeter\n"
                + "6. Get Rectangle Area\n"
                + "7. Exit";
            int length = 0;
            int width = 0;
            bool exitProgram = false;

            Console.WriteLine("Welcome to the Rectangle Formatter!");
            Console.WriteLine("Please enter the length of the rectangle.");
            length = GetUserMeasurement();
            Console.WriteLine("Please enter the width of the rectangle.");
            width = GetUserMeasurement();

            Rectangle rectangle = new Rectangle(width, length);

            while (!exitProgram)
            {
                Console.WriteLine("\n" + menu);
                exitProgram = GetUserSelection(ref rectangle);
            }


        }

        static int GetUserMeasurement()
        {
            bool isValid = false;
            string input = "";
            int returnValue = 0;
            while (!isValid)
            {
                returnValue = 0;
                input = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a value.");
                }

                else if(int.TryParse(input, out returnValue))
                {
                    if(returnValue > 0) isValid = true;
                    else
                    {
                        Console.WriteLine("Please enter a number greater than zero.");
                    }
                }

                else
                {
                    Console.WriteLine("Please enter a positive integer.");
                }
                
            }

            return returnValue;
        }

        static bool GetUserSelection(ref Rectangle rectangle)
        {
            const int GET_RECTANGLE_LENGTH = 1;
            const int CHANGE_RECTANGLE_LENGTH = 2;
            const int GET_RECTANGLE_WIDTH = 3;
            const int CHANGE_RECTANGLE_WIDTH = 4;
            const int GET_RECTANGLE_PERIMETER = 5;
            const int GET_RECTANGLE_AREA = 6;
            const int EXIT = 7;

            bool result = false;
            string input = Console.ReadLine().Trim();
            int selection;
            int response;
            int userMeasurement = 0;

            if(input.Length != 1)
            {
                Console.WriteLine("Please enter the number of the menu option you'd like to select.");
            }

            //if not all of the characters are digits
            else if(!input.All(char.IsDigit))
            {
                Console.WriteLine("Please only enter integers.");
            }

            else
            {
                selection = Convert.ToInt32(input);

                switch (selection)
                {
                    case GET_RECTANGLE_LENGTH:
                        response = rectangle.GetLength();
                        Console.Clear();
                        Console.WriteLine("The rectangle is " + Convert.ToInt32(response) + " long.");
                        break;

                    case CHANGE_RECTANGLE_LENGTH:
                        Console.WriteLine("Please enter the new length.");
                        userMeasurement = GetUserMeasurement();
                        response = rectangle.SetLength(userMeasurement);
                        Console.Clear();
                        Console.WriteLine("The rectangle is now " + Convert.ToInt32(response) + " long.");
                        break;

                    case GET_RECTANGLE_WIDTH:
                        response = rectangle.GetWidth();
                        Console.Clear();
                        Console.WriteLine("The rectangle is " + Convert.ToInt32(response) + " wide.");
                        break;

                    case CHANGE_RECTANGLE_WIDTH:
                        Console.WriteLine("Please enter the new width.");
                        userMeasurement = GetUserMeasurement();
                        response = rectangle.SetWidth(userMeasurement);
                        Console.Clear();
                        Console.WriteLine("The rectangle is now " + Convert.ToInt32(response) + " wide.");
                        break;

                    case GET_RECTANGLE_PERIMETER:
                        response = rectangle.GetPerimeter();
                        Console.Clear();
                        Console.WriteLine("The perimeter is " + Convert.ToInt32(response));
                        break;

                    case GET_RECTANGLE_AREA:
                        response = rectangle.GetArea();
                        Console.Clear();
                        Console.WriteLine("The area is " + Convert.ToInt32(response));
                        break;

                    case EXIT:
                        result = true;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid menu option.");
                        break;


                }
            }

            return result;
        }

    }
}
