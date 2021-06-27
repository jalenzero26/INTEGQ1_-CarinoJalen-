using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class FacultyData
    {
        public void shwFaculty()
        {
            {

                for (int i = 0; i < 10; i++)
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("            FACULTY             ");
                    Console.WriteLine("--------------------------------");

                    var faculty = new List<string>
                {"Adem Myers", "Bear Mcneil", "Colin Maxwell", "Cristina Daugherty",
                        "Dennis Vang", "Imani Cordova", "Ismael Le", "Jozef Stubbs",
                        "Loretta Mccullough", "Phillipa Chung", "Sami Hardin", "Samiya Krause",
                        "Sarah Riggs", "Tyreece Solomon","Yara Workman", "Zayden Barrow",};

                    foreach (var showProf in faculty)
                    {
                        Console.WriteLine($"Prof: " + showProf);

                    }
                }
            }
        }
    }
}
