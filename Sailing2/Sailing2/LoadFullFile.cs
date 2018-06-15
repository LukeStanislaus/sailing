using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing2
{
    class LoadFullFile
    {
        public void newpersontofile(string person)
        {
            Console.WriteLine("Your name, " + person + ", is not in my records, would you like to add it?(y/n)");
            string response = Console.ReadLine();
            if (string.Equals(response, "y"))
            {
                Console.WriteLine("Please re-enter your name, capitalised how you want it.");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter the number of boats you have.");
                int noOfBoats = int.Parse(Console.ReadLine());
                for (int i = 0; i < noOfBoats; i++)
                {
                    Console.WriteLine("Enter the name of boat {0}", i);
                    string boat = Console.ReadLine();
                    Console.Write("Enter the boat number of boat {0}", i);
                    int boatNumber = int.Parse(Console.ReadLine());
                    using (StreamWriter file =
new StreamWriter(@"c:\temp\Full List.txt", true))
                    {
                        file.WriteLine("{0}\t{1}\t{2}", name, boatNumber, boat);
                        //LoadFullSQL.AddPerson()

                    }


                }
            }
        }
        public void racerwritetofile(BoatsRacing racer, string path)
        {
            using (StreamWriter sw = System.IO.File.AppendText(@path + @"\Race List.txt"))
            {
                sw.WriteLine("{0}, {1}, {2}", racer.name,
                    racer.boatName,
                    racer.boatNumber);
            }
        }
        public static void ExportToFile(List<BoatsFromExcel> fulllist, string path)
        {
            BoatsFromExcel tempboat = new BoatsFromExcel();
            //using (StreamWriter sw = File.AppendText(@path + @"\FullDump.csv"))
            //{
                foreach (var entry in fulllist)

                    LoadFullSQL.SQLAddboat(entry.name, entry.boat, entry.boatNumber);
                    //sw.WriteLine("{0},{1},{2}", tempboat.name, 
                        //tempboat.boat, tempboat.boatNumber);
            //}
        }

        public static Dictionary<string, Boats> loadFullFile(string path)
        //public static string LoadFullFile()
        {
            StreamReader reader = System.IO.File.OpenText(@path + @"Full List.txt");
            string line;
            Dictionary<int, BoatsFromExcel> BoatDictionaryInterim = new Dictionary<int, BoatsFromExcel>();
            Dictionary<string, Boats> BoatDictionary = new Dictionary<string, Boats>();

            int count1 = 0;
            while ((line = reader.ReadLine()) != null)

            {
                string[] items = line.Split(char.Parse("\n"));

                while ((line = reader.ReadLine()) != null)
                {
                    string[] items1 = line.Split('\t');
                    BoatsFromExcel boat1 = new BoatsFromExcel(items1[0], int.Parse(items1[1]), items1[2]);
                    BoatDictionaryInterim.Add(count1, boat1);
                    count1++;
                }


            }
            List<string> keys = new List<string>();

            int m = 0;
            foreach (KeyValuePair<int, BoatsFromExcel> Boat in BoatDictionaryInterim)
            {
                if (keys.Contains(BoatDictionaryInterim[m].name))
                {
                    if (BoatDictionary[BoatDictionaryInterim[m].name].boat2 == null)
                    {
                        Boats boat1 = new Boats(BoatDictionaryInterim[m].name,
                        BoatDictionary[BoatDictionaryInterim[m].name].boat1,
                        BoatDictionary[BoatDictionaryInterim[m].name].boatNumber1,
                        BoatDictionaryInterim[m].boat,
                        BoatDictionaryInterim[m].boatNumber);
                        BoatDictionary.Remove(BoatDictionaryInterim[m].name);
                        BoatDictionary.Add(boat1.name, boat1);
                    }
                    else if (BoatDictionary[BoatDictionaryInterim[m].name].boat3 == null)
                    {

                        Boats boat1 = new Boats(BoatDictionaryInterim[m].name,
                        BoatDictionary[BoatDictionaryInterim[m].name].boat1,
                        BoatDictionary[BoatDictionaryInterim[m].name].boatNumber1,
                        BoatDictionary[BoatDictionaryInterim[m].name].boat2,
                        BoatDictionary[BoatDictionaryInterim[m].name].boatNumber2,
                        BoatDictionaryInterim[m].boat,
                        BoatDictionaryInterim[m].boatNumber);
                        BoatDictionary.Remove(BoatDictionaryInterim[m].name);
                        BoatDictionary.Add(boat1.name, boat1);
                    }
                    else if (BoatDictionary[BoatDictionaryInterim[m].name].boat4 == null)
                    {
                        Boats boat1 = new Boats(BoatDictionaryInterim[m].name,
                        BoatDictionary[BoatDictionaryInterim[m].name].boat1,
                        BoatDictionary[BoatDictionaryInterim[m].name].boatNumber1,
                        BoatDictionary[BoatDictionaryInterim[m].name].boat2,
                        BoatDictionary[BoatDictionaryInterim[m].name].boatNumber2,
                        BoatDictionary[BoatDictionaryInterim[m].name].boat3,
                        BoatDictionary[BoatDictionaryInterim[m].name].boatNumber3,
                        BoatDictionaryInterim[m].boat,
                        BoatDictionaryInterim[m].boatNumber);
                        BoatDictionary.Remove(BoatDictionaryInterim[m].name);
                        BoatDictionary.Add(boat1.name, boat1);
                    }
                    else if (BoatDictionary[BoatDictionaryInterim[m].name].boat5 == null)
                    {
                        Boats boat1 = new Boats(BoatDictionaryInterim[m].name,
                        BoatDictionary[BoatDictionaryInterim[m].name].boat1,
                        BoatDictionary[BoatDictionaryInterim[m].name].boatNumber1,
                        BoatDictionary[BoatDictionaryInterim[m].name].boat2,
                        BoatDictionary[BoatDictionaryInterim[m].name].boatNumber2,
                        BoatDictionary[BoatDictionaryInterim[m].name].boat3,
                        BoatDictionary[BoatDictionaryInterim[m].name].boatNumber3,
                        BoatDictionary[BoatDictionaryInterim[m].name].boat4,
                        BoatDictionary[BoatDictionaryInterim[m].name].boatNumber4,
                        BoatDictionaryInterim[m].boat,
                        BoatDictionaryInterim[m].boatNumber);
                        BoatDictionary.Remove(BoatDictionaryInterim[m].name);
                        BoatDictionary.Add(boat1.name, boat1);
                    }

                }
                else
                {
                    Boats boat3 = new Boats(BoatDictionaryInterim[m].name,
                    BoatDictionaryInterim[m].boat,
                    BoatDictionaryInterim[m].boatNumber);
                    BoatDictionary.Add(boat3.name, boat3);
                    keys.Add(BoatDictionaryInterim[m].name);
                }
                m++;






            }
            reader.Close();
            return BoatDictionary;
        }
    }
}

