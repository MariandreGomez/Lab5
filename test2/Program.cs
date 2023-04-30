using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

public class Program
{
    public class InputLab
    {
        public Dictionary<string, bool>[] input1 { get; set; }
        public string[] input2 { get; set; }
    }

    public static void Main()
    {
        int counter = 0;
        int apartment = 0;
        int counter1 = 0;
        int counter2 = 0;
        string keys;
        bool values = true;
        string requrement1 = "";
        string requrement2 = "";
        string requrement3 = "";
        string requrement4 = "";
        string requrement5="";

        InputLab input = new InputLab();

        foreach (String line in System.IO.File.ReadLines(@"C:\Users\maria\Desktop\input_example.jsonl"))
        {
           
            input = JsonSerializer.Deserialize<InputLab>(line);
            counter++;
            counter2 =input.input1.Count();
            counter1 = input.input2.Count();

            if (counter1 == 3)
            {
                for (int m = 0; m < counter1; m++)
                {
                    requrement1 = (string)input.input2.GetValue(m);
                    Console.WriteLine($"requirement: {input.input2.GetValue(m)}");
                    m++;
                    requrement2 = (string)input.input2.GetValue(m);
                    Console.WriteLine($"requirement: {input.input2.GetValue(m)}");
                    m++;
                    requrement3 = (string)input.input2.GetValue(m);
                    Console.WriteLine($"requirement: {input.input2.GetValue(m)}");

                }


                Console.WriteLine($"-----------");

                int[,] imputs1 = new int[counter2, counter1];

                foreach (Dictionary<string, bool> map in input.input1)
                {
                    Console.WriteLine($"apartment: {apartment}");
                    foreach (KeyValuePair<string, bool> entry in map)
                    {
                        Console.WriteLine($"key {entry.Key} - value {entry.Value}");
                        keys = entry.Key;
                        values = entry.Value;

                        for (int i = 0; i < counter2; i++)
                        {
                            for (int j = 0; j < counter1; j++)
                            {
                                if (keys == "Bar" || keys == "Clinic" || keys == "Park")
                                {
                                    if (values == true)
                                    {

                                        imputs1[i, j] = 1;
                                        Console.WriteLine(imputs1[i, j]);


                                    }
                                    if (values == false)
                                    {
                                        imputs1[i, j] = 0;
                                        Console.WriteLine(imputs1[i, j]);
                                    }

                                    keys = "hola";
                                }

                               
                               
                            }
                           
                        }


                    }
                    apartment++;
                    Console.WriteLine($"-----------");
                }

                apartment = 0;
            }
            if (counter1 == 4)
            {
                for (int m = 0; m < counter1; m++)
                {
                    requrement1 = (string)input.input2.GetValue(m);
                    Console.WriteLine($"requirement: {input.input2.GetValue(m)}");
                    m++;
                    requrement2 = (string)input.input2.GetValue(m);
                    Console.WriteLine($"requirement: {input.input2.GetValue(m)}");
                    m++;
                    requrement3 = (string)input.input2.GetValue(m);
                    Console.WriteLine($"requirement: {input.input2.GetValue(m)}");
                    m++;
                    requrement4 = (string)input.input2.GetValue(m);
                    Console.WriteLine($"requirement: {input.input2.GetValue(m)}");

                }


                Console.WriteLine($"-----------");

                int[,] imputs11 = new int[counter2, counter1];

                foreach (Dictionary<string, bool> map1 in input.input1)
                {
                    Console.WriteLine($"apartment: {apartment}");
                    foreach (KeyValuePair<string, bool> entry in map1)
                    {
                        Console.WriteLine($"key {entry.Key} - value {entry.Value}");
                        keys = entry.Key;
                        values = entry.Value;


                    }
                    apartment++;
                    Console.WriteLine($"-----------");
                }

                apartment = 0;
            }
            if (counter1 == 5)
            {
                for (int m = 0; m < counter1; m++)
                {
                    requrement1 = (string)input.input2.GetValue(m);
                    Console.WriteLine($"requirement: {input.input2.GetValue(m)}");
                    m++;
                    requrement2 = (string)input.input2.GetValue(m);
                    Console.WriteLine($"requirement: {input.input2.GetValue(m)}");
                    m++;
                    requrement3 = (string)input.input2.GetValue(m);
                    Console.WriteLine($"requirement: {input.input2.GetValue(m)}");
                    m++;
                    requrement4 = (string)input.input2.GetValue(m);
                    Console.WriteLine($"requirement: {input.input2.GetValue(m)}");
                    m++;
                    requrement5 = (string)input.input2.GetValue(m);
                    Console.WriteLine($"requirement: {input.input2.GetValue(m)}");

                }


                Console.WriteLine($"-----------");

                int[,] imputs111 = new int[counter2, counter1];

                foreach (Dictionary<string, bool> map11 in input.input1)
                {
                    Console.WriteLine($"apartment: {apartment}");
                    foreach (KeyValuePair<string, bool> entry in map11)
                    {
                        Console.WriteLine($"key {entry.Key} - value {entry.Value}");
                        keys = entry.Key;
                        values = entry.Value;


                    }
                    apartment++;
                    Console.WriteLine($"-----------");
                }

                apartment = 0;
            }

        }
           
        
        System.Console.WriteLine("There were {0} lines.", counter);
        Console.ReadKey();
    }
}