using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeGeneric.Models
{
    public class MyStrList
    {
        private string[] arr = default;


        public MyStrList()
        {
            arr = new string[0];
        }


        public void Add(string str)
        {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length-1] = str;
        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class MyIntList
    {
        private int[] arr = default;


        public MyIntList()
        {
            arr = new int[0];
        }


        public void Add(int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class MyUserList
    {
        private string[] arr = default;


        public MyUserList()
        {
            arr = new string[0];
        }


        public void Add(string str)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = str;
        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }




    public class MyList<T>   // Qadağalar:  where T: class
                             //             where T : base class
    {                            //where T : new()
                              //where T : interface adi
        //where T : struct
        //where T : miras aldiqi
        private T[] arr = default;


        public MyList()
        {
            arr = new T[0];
        }


        public void Add(T str)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = str;
        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
