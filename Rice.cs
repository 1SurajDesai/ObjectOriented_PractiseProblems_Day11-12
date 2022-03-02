using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventaroryDataManagmentDemo
{
    public class Rice
    {
        public List<TypeofRice> typeofRice;
        public List<TypesOfPulses> TypesOfPulses;
        public List<TypesOfWheats> TypesOfWheats;
    }
    public class TypeofRice
    {
        public string name;
        public string weight;
        public int price;

    }
    public class TypesOfPulses
    {
        public string name;
        public string weight;
        public int price;

    }
    public class TypesOfWheats
    {
        public string name;
        public string weight;
        public int price;

    }
}
