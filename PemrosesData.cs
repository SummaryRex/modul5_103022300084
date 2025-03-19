
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300084
{
    internal class PemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T data1, T data2, T data3)
        {
            dynamic temp1 = data1;
            dynamic temp2 = data2;
            dynamic temp3 = data3;

            if (temp1 > temp2 && temp1 > temp3)
            {
                temp1 = data1;
            }
            else if (temp2 > temp1 && temp2 > temp3)
            {
                temp1 = data2;
            }
            else 
            {
                temp1 = data3; 
            }

            Console.WriteLine("Nilai terbesar: "+temp1);
        }
    }


    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
        }
        public void AddNewData(T data) 
        { 
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }
        public void PrintAllData() {
            for (int i = 0; i < storedData.Count; i++) 
            {
                Console.WriteLine("Data " + i + " berisi: " + storedData[i] +
                    ", yang disimpang pada waktu UTC: " + inputDates[i]);    
            }
        }
    }
}
