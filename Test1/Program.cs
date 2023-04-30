using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using Test1.Clases;
using System.Linq;
using static Test1.Program;

namespace Test1
{
    internal class Program
    {
        public class InputLab
        {
            public Dictionary<string, bool>[] input1 { get; set; }
            public string[] input2 { get; set; }
        }
        static void Main(string[] args)
        {
            string line = File.ReadAllText(@"C:\Users\maria\Desktop\inputaux1.json");
            // string line = "{\"input1\":[{\"Academy\":true,\"Gym\":false,\"Store\":false},{\"Academy\":false,\"Gym\":true,\"Store\":false},{\"Academy\":true,\"Gym\":true,\"Store\":false},{\"Academy\":true,\"Gym\":false,\"Store\":false},{\"Academy\":true,\"Gym\":false,\"Store\":true}],\"input2\":[\"Academy\",\"Gym\",\"Store\"]}";
            Root[] root = System.Text.Json.JsonSerializer.Deserialize<Root[]>(line);

            List<Input1> inputs1 = root[0].input1.ToList();
            List<string> inputs2 = root[0].input2.ToList();
            int cont = 0;
            foreach (var item in inputs1)
            {
                Console.WriteLine($"There are {item.Pharmacy} Farmacy");
                Console.WriteLine($"There are {item.Restaurant} Restaurant");
                Console.WriteLine($"There are {item.BeautySalon}  BeautySalon");
                Console.WriteLine($"There are {item.Mall} Mall");
                Console.WriteLine($"There are {item.Vet} vet");
                Console.WriteLine($"There are {item.Hospital} Hospital");
                Console.WriteLine($"There are {item.Academy} Academy");
                Console.WriteLine($"There are {item.Clinic} clinic");
                Console.WriteLine($"There are {item.Kindergarten} Kindergarten");
                Console.WriteLine($"There are {item.GasStation} GasSation");
                Console.WriteLine($"There are {item.Park} Park");
                Console.WriteLine($"There are {item.Cofeeshop} Coffeshop");
                Console.WriteLine($"There are {item.Grocery} Grocey");
                Console.WriteLine($"There are {item.BarberShop} BarberShop");
                Console.WriteLine($"There are {item.Gym} GYM");
                Console.WriteLine($"There are {item.Bakery} Bakery");
                Console.WriteLine($"There are {item.Bar} Bar");
                Console.WriteLine($"------------------------------------------------------");
                cont++;

               // for (int i = 0; i < inputs2.Count(); i++)
               // {
                    //string local = inputs2[i].ToString();
                    //Console.WriteLine(inputs2[i]);
                    bool aux =Convert.ToBoolean(item.Bar);
                    bool aux1 = Convert.ToBoolean(item.Clinic);
                    bool aux2 = Convert.ToBoolean(item.Park);
                    
                    if (aux.ToString() == "True" || aux1.ToString() == "True" || aux2.ToString() == "True")
                    {

                        Console.WriteLine("HOLA");

                         //Console.WriteLine(Convert.ToString(cont));

                        
                    }
                    

               // }

            }

           

          



            Console.Write(root[0].input1[0].Restaurant);
            Console.ReadKey();
        }
    }
}
