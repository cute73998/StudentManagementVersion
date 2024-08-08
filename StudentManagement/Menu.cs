using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Menu
    {
        public void homeMenu()
        {
            Console.WriteLine("WELCOME TO STUDENT MANAGEMENT");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Find and Sort");
            Console.WriteLine("3. Update/Delete");
            Console.WriteLine("4. Report");
            Console.WriteLine("5. Exit");
            Console.WriteLine("   (Please choose 1 to Create, 2 to Find and Sort, 3 to Update/Delete, 4 to Report and 5 to Exit program).");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            Console.WriteLine();
            int choice = int.Parse(Console.ReadLine());
            Controller choices = new Controller();
            switch (choice)
            {
                case 1:
                    choices.createStudents();
                    break;

                case 2:
                    choices.Function2();
                    break;

                case 3:

                    break;
                case 4:

                    break;

                case 5:

                    break;

                default:

                    break;
            }
        }
    }
}
