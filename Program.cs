using System.Reflection;

namespace Reflection.task
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Type usertype = typeof(User);
            User user1 = (User)Activator.CreateInstance(usertype);

            FieldInfo fieldId = usertype.GetField("id", BindingFlags.NonPublic  | BindingFlags.Instance);
            fieldId.SetValue(user1,8);

            FieldInfo fieldName = usertype.GetField("name", BindingFlags.NonPublic | BindingFlags.Instance);
            fieldId.SetValue(user1, "Mehpare");

            FieldInfo fieldSurname = usertype.GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance);
            fieldSurname.SetValue(user1, "Kicibeyova");

            FieldInfo fieldAge = usertype.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance |BindingFlags.Static);
            fieldAge.SetValue(user1, 20);
            

            Console.WriteLine("ID:"+fieldId.GetValue);
         //   Console.WriteLine("ad:"+fieldName.GetValue);
           // Console.WriteLine("soyad:"+fieldSurname.GetValue);
            Console.WriteLine("yas:" + fieldAge.GetValue);


            MethodInfo method1 = usertype.GetMethod("GetFullName", BindingFlags.Public | BindingFlags.Instance);
            method1.Invoke(user1 fieldId, fieldName, fieldSurname, fieldAge);

            Console.ReadKey();
        }
    }
}
