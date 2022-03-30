using System;
using Models;

namespace IntroduceYourself
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Introduce();

            Employee employee = new Employee();
            employee.Introduce();
        }
    }
}
