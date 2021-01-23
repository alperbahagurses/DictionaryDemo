using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> category = new MyDictionary<int, string>();
            category.Add(1, "Elektronik");
            category.Add(2,"Kitap");
            category.Add(3, "Bahçe");
            category.Add(4, "Kırtasiye");
            category.Add(5, "Ayakkabı");
            category.Add(6, "Aksesuar");

            foreach (var id in category.Ids)
            {
                Console.WriteLine("Kategori : "+id);
            }
            Console.WriteLine("-----------------------------------");
            foreach (var name in category.Names)
            {
                Console.WriteLine("Kategori Adı : "+name);
            }
        }
    }
}
