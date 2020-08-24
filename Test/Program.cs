using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //此处出现错误，C#中声明数组时，[]必须放在数组名的前面，紧跟着数组类型，可以将代码修改如下：
            //int[] day = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] day = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
             for (int i = 0; i < 12; i++)                                //利用循环将信息输出
                 {
                     Console.WriteLine((i + 1) + "月有" + day[i] + "天");       //输出的信息
                 }
            Console.WriteLine("dfsdfsd");
             Console.ReadLine();
            Console.ReadLine();
        }
    }
}
