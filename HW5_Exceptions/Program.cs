using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Exceptions
{
    class Program
    {
        static public void GetWebsite()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("www.microsoft.com");
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                Console.WriteLine(request.Address);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                Console.WriteLine(message);
            }

        }
        static public void PrintArray(int[] arr)
        {
            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Массив обработан");
            }
        }

        static public void DivideNumbers(int a, int b)
        {
            try
            {
                int res = a/b;
                Console.WriteLine(res);
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }

        }

        static void Main(string[] args)
        {
            //GetWebsite();
            int[] array = { 1, 2, 4, 23, 34, 23, 45, 56 };
            //PrintArray(array);

            try
            {
                DivideNumbers(2, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
