using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Atoms
{
    class Program
    {


        static void Main(string[] args)
        {
            //add the following statement in global scope
            //To create a collection to work with
            Atom[] elements = new Atom[110];
            Atom.AddElements(ref elements);
            Atom.DisplayAllElemetns(elements);
            Console.WriteLine("XML SERIALIZATION");
            elements[0].Save("elements.txt");
            Console.WriteLine(Atom.Load("elements.txt").GetInfo());

            Console.WriteLine("XML SERIALIZATION ALL");
            Atom.SaveAll("Allelements.txt", elements);
            Atom[] testLoad = Atom.LoadAll("Allelements.txt");
            foreach (Atom item in testLoad)
            {
                Console.WriteLine(item.GetInfo());
            }

            Console.WriteLine(" ONE ITEM JSON" );
            Atom.SaveJson("element.txt", elements[0]);
            Console.WriteLine(Atom.LoadJson("element.txt").GetInfo());



            Console.WriteLine("ALL ITEMS USING JSON");
            Atom.SaveAllJson("elementss.txt", elements);
            Atom[] testLoadJson = Atom.LoadAllJson("elementss.txt");

            foreach (Atom item in testLoadJson)
            {
                Console.WriteLine(item.GetInfo());

            }

            


        }
    }
}
