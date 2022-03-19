using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD4_1302204058
{
    public class ClassMain
    {
        public static void Main(string[] args)
        {
            SimpleDataBase<int> objData = new SimpleDataBase<int>();
            objData.AddNewData(12, DateTime.Now);
            objData.AddNewData(34, DateTime.Now);
            objData.AddNewData(56, DateTime.Now);
            objData.PrintAllData();
            Console.ReadKey();
        }
    }

    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }
        public void AddNewData(T dataBaru, DateTime dataDate)
        {
            storedData.Add(dataBaru);
            inputDates.Add(dataDate);
        }
        public void PrintAllData()
        {
            foreach (T Data in storedData)
            {
                Console.WriteLine(Data);
            }
            foreach (DateTime DataDate in inputDates)
            {
                Console.WriteLine(DataDate);
            }
        }
    }
}