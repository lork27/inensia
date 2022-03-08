using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.IO;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var stars = OneClassObject();
            if (stars != null)
            {
                for (int i = 0; i < stars.Count; i++)
                {
                    stars[i].PrintStar();
                    Console.WriteLine();
                }
            }

        }

        static List<MovieStar> OneClassObject()
        {
            string filename = @"./input.txt";
            if (File.Exists(filename))
            {
                var stars = JsonConvert.DeserializeObject<List<MovieStar>>(File.ReadAllText(filename));
                return stars;
            }
            return null;
        }
    }
}