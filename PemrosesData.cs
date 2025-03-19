
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022300084
{
    internal class PemrosesData
    {
        /*private T data;
        private dynamic temp;*/

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

            Console.WriteLine(temp1);
        }
    }

    
}
