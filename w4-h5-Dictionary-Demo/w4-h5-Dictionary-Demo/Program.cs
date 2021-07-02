using System;
using System.Collections.Generic;

namespace w4_h5_Dictionary_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();
            students.Add(101,"Rafet");
            students.Add(102, "Seda");
            students.Add(103, "Berkay");
            students.Add(104, "Salih");
            students.Add(105, "Rafet");
            students.Add(102, "Ahmet"); // Ogrencilere eklenmeyecektir ve ekrana bu bilgi yazdirilacaktır. Cunku aynı anahtara sahip baska bir ogrenci bulunmaktadir.
        }
    }
}
