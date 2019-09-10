using System;
using System.Linq;

namespace LinqOpg
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = MCronberg.PersonRepositoryStatic.JustGetPeople();
            //foreach (var person in people)
            //    Console.WriteLine(person.Name);

            //Sorter og udskriv efter navn og udskriv
            // de to første linjer er to forskellige måder at gøre det samme på.

            //Console.WriteLine();
            //var res1 = people.OrderBy(i => i.Name);
            //var res1l = from person in people orderby person.Name select person;
            //foreach (var person in res1)
            //    Console.WriteLine(person.Name);

            //Sorter og udskriv efter gender og så navn
            // de to første linjer er to forskellige måder at gøre det samme på.

            //Console.WriteLine();
            //var res2 = people.OrderBy(i => i.Gender).ThenBy(i => i.Name);
            //var res2l = from person in people orderby person.Gender, person.Name select person;
            //foreach (var person in res2l)
            //    Console.WriteLine(person.Name + " " + person.Gender);

            //Filtre og udskriv således, at der kun vises personer hvor height < 170
            // de to første linjer er to forskellige måder at gøre det samme på.

            //Console.WriteLine();
            //var res3 = people.Where(i => i.Height < 170);
            //var res3l = from person in people where person.Height < 170 select person;
            //foreach (var person in res3)
            //    Console.WriteLine(person.Name + " " + person.Height);

            //Filtre og udskriv således, at der kun vises personer hvor height = < 170, isHealthy = true
            //Console.WriteLine();
            //var res4 = people.Where(i => i.Height < 170 && i.IsHealthy);
            //foreach (var person in res4)
            //    Console.WriteLine(person.Name + " " + person.Height + " " + person.IsHealthy);

            //Gruppér efter gender og udskriv hver gruppe (husk – der er tale om tilfældige navn/gender mv)
            //Console.WriteLine();
            //var res5 = people.GroupBy(i => i.Gender);
            //foreach (var group in res5)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var person in group)
            //        Console.WriteLine("  => " + person.Name + " " + person.Gender);

            //}

            //Sorter og udskriv navn – men der skal kun returneres et anonymt objekt med navn og height
            //Console.WriteLine();
            //var res6 = people.OrderBy(i => i.Name).Select(i => new { Name = i.Name, Height = i.Height });
            //foreach (var person in res6)
            //{
            //    Console.WriteLine(person.Name + " " + person.Height);
            //}

            //Grupper og sorter efter height således, at der skabes grupper fra 160-170, 170-180, 180-190, 190-200, 200-210.
            Console.WriteLine();
            var res7 = people.OrderBy(i => i.Height).GroupBy(i => i.Height / 10);
            foreach (var group in res7)
            {
                Console.WriteLine(group.Key * 10);
                foreach (var person in group)
                {
                    Console.WriteLine("  => " + person.Name + " " + person.Height);
                }
            }
        }
    }
}
