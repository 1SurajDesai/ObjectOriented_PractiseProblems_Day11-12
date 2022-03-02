using System;
namespace InventaroryDataManagmentDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "C:/Visual Studio/InventoryDataManagementDemo/Rice.jason";

            FetchJasonForRice fetchJasonForRice = new FetchJasonForRice();
            Rice data = fetchJasonForRice.Read(path);

            for (int i = 0; i < data.typeofRice.Count; i++)
            {
                Console.WriteLine(data.typeofRice[i].name);
                Console.WriteLine(data.typeofRice[i].weight);
                Console.WriteLine(data.typeofRice[i].price);
                Console.WriteLine();
            }
            for (int i = 0; i < data.TypesOfPulses.Count; i++)
            {
                Console.WriteLine(data.TypesOfPulses[i].name);
                Console.WriteLine(data.TypesOfPulses[i].weight);
                Console.WriteLine(data.TypesOfPulses[i].price);
                Console.WriteLine();
            }
            for (int i = 0; i < data.TypesOfWheats.Count; i++)
            {
                Console.WriteLine(data.TypesOfWheats[i].name);
                Console.WriteLine(data.TypesOfWheats[i].weight);
                Console.WriteLine(data.TypesOfWheats[i].price);
                Console.WriteLine();
            }


            
        }

    }
}

