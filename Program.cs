using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1_C0725626
{
            
class Program
        {
            static void Main(string[] args)
            {
                Countryside Ontario = new Countryside();
                Ontario.run();

            }
        }

        class Example
        {
            public void run()
            {
                Village Toronto;
                Village a;
                Village b;
                Toronto = new Village();
                a = Toronto;

                Toronto = new Village();
                b = Toronto;

                if (a == b) { Console.WriteLine("both are same"); }
                else
                {
                    Console.WriteLine("they are different");
                    Console.ReadLine();
                }
            }
        }
        class Village
        {
            public static int numberOfVillages = 0;
            public Village nextVillage;
            public Village previousVillage;
            public string VillageName;
            public bool isAstrildeHere = false;

            public Village()
            {
                Village.numberOfVillages++;
            }
        }

        class Countryside
        {
            public Village Maple;
            public Village Toronto;
            public Village Ajax;
            public Village Head;
            public Village Tail;
            public Village Current;

            public void run()
            {
                this.MapInitializer();
                this.LookForAstrilde();
                Console.WriteLine("Astrilde found in " + Current.VillageName);
                Console.ReadLine();
            }

            public void MapInitializer()
            {
                Ajax = new Village();
                Toronto = new Village();
                Maple = new Village();

                Maple.VillageName = "Maple";
                Maple.previousVillage = null;
                Maple.nextVillage = Toronto;
                Ajax.isAstrildeHere = true;

                Toronto.previousVillage = Maple;
                Toronto.VillageName = "Toronto";
                Toronto.nextVillage = Ajax;

                Ajax.VillageName = "Ajax";
                Ajax.nextVillage = null;
                Ajax.previousVillage = Toronto;

            }


            public void LookForAstrilde()
            {
                Current = Maple;
                while (Current.nextVillage != null)
                {
                    if (Current.isAstrildeHere)
                    {
                        Console.WriteLine("He Found Astrilde");
                        Console.ReadLine();
                        return;
                    }
                    else
                    {
                        Current = Current.nextVillage;
                    }
                }


            }
        }

    }


