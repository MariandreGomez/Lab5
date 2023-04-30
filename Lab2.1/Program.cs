using System;
//using System.Text.Json;
//using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Newtonsoft.Json;

public class Program
{
    public class House
    {
        public string zoneDangerous { get; set; }
        public string address { get; set; }
        public double price { get; set; }
        public string contactPhone { get; set; }
        public string id { get; set; }
    }
    public class Apartment
    {
        public bool isPetFriendly { get; set; }
        public string address { get; set; }
        public double price { get; set; }
        public string contactPhone { get; set; }
        public string id { get; set; }
    }
    public class Premise
    {
        public string[] commercialActivities { get; set; }
        public string address { get; set; }
        public double price { get; set; }
        public string contactPhone { get; set; }
        public string id { get; set; }
    }
    public class Builds
    {
        public Premise[] Premises { get; set; }
        public Apartment[] Apartments { get; set; }
        public House[] Houses { get; set; }
    }
    public class Input1
    {
        public Dictionary<string, bool> services { get; set; }
        public Builds builds { get; set; }

    }
    public class Input2
    {
        public double budget { get; set; }
        public string typeBuilder { get; set; }
        public string[] requiredServices { get; set; }
        public string commercialActivity { get; set; }
        public bool? wannaPetFriendly { get; set; }
        public string minDanger { get; set; }
    }
    public class InputLab
    {
        public Input1[] input1 { get; set; }
        public Input2 input2 { get; set; }
    }

    public static void Main()
    {
        //StreamWriter streamWriter = new StreamWriter(@"C:\Users\maria\Desktop\input_challenge_lab_2.jsonl");


        string line;
        try
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(@"C:\\lab\\input_challenge_lab_2.txt");
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            Console.ReadLine();
            InputLab input = JsonConvert.DeserializeObject<InputLab>(line);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }

        //string line = (@"C:\Users\maria\Desktop\input_example.jsonl"); // su json aca
        
    }
}
