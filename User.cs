using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.task
{
  public  class User
    {
        private string name;
        private string surname;
        private int  id;
        private static int age;
        public void GetFullName()
        {
            Console.WriteLine($"ad:{name},soyad:{surname}dir");
        }
        public static void ChangeAge(int age)
        {
            age =age;
        }
    }
}
