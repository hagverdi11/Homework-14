using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections_Homework_Practice
{
    class Program
    {
        static void Main(string[] args)
        {


            Hashtable datas = new Hashtable();
            datas.Add(1, "Orxan");
            datas.Add(2, "Eli");
            foreach (var item in datas)
            {
                Console.WriteLine(item);
            }
            //List<int> nums = new List<int>();
            //nums.Add(5);
            //nums.Add(10);
            //nums.Add(15);
            //nums.Add(20);


            //List<string> words = new List<string>();
            //words.Add("asas");
            //words.Add("assas");
            //words.Add("osas");
            //words.Add("uvuvuvuve");

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i <nums.Count; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //if (nums.Count == 4)
            //{
            //    Console.WriteLine("True");
            //}

            //List<Employers> workers = new List<Employers>();

            //Employers worker = new Employers();
            //worker.Name = "Filankes";
            //workers.Add(worker);

            //workers.Add(new Employers { Id = 1, Name = "Eli", Position = "Engineer" });
            //workers.Add(new Employers { Id = 2, Name = "Veli", Position = "Programmer" });
            //workers.Add(new Employers { Id = 3, Name = "Mirze", Position = "Poet" });
            //workers.Add(new Employers { Id = 4, Name = "Elekber", Position = "Director" });


            //GetWorkers(workers);

        }

        


        //public static void GetWorkers(List<Employers> employers)
        //{
        //    foreach(var item in employers)
        //    {
        //        Console.WriteLine("Employers: Id - {0}, Name - {1}, Position - {2}", item.Id, item.Name, item.Position);
        //    }
        //}


        //public static Person GetPersonByName(List<Person> people, string name) 
        //{
        //    var result = people.Find(m => m.Name);
        //    return result;
        //}


        //public class Employers
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public string Position { get; set; }
        //}
    }
}
