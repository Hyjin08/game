using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string name;
            name = "hello";
            Console.WriteLine(name);
            string ret = Console.ReadLine();
            Console.WriteLine(name + ret);
            */
            /*string strdata = "정말로 반가워!! 행복한 하루";

            Console.WriteLine(strdata.IndexOf("반"));
            Console.WriteLine(strdata.IndexOf("행복"));
            
            Console.WriteLine(strdata.Contains("!!"));
            Console.WriteLine(strdata.Contains("하루들"));

            strdata = strdata.Replace("행복한", "즐거운");
            Console.WriteLine(strdata);

            string strdata2 = "Happy Day. Good!!";
            Console.WriteLine(strdata2.ToUpper());
            Console.WriteLine(strdata2.ToLower());
            Console.WriteLine(strdata2.Insert(5,"hi"));
            Console.WriteLine(strdata2.Remove(2, 3));
            Console.WriteLine(strdata2.Remove(7));
            */
            Cast.CastString();
        }
    }
    internal class Cast
    {
        public static void CastString()
        {
            float num1 = 3.14159f;
            int retvalue = 0;

            Console.WriteLine("원본 실수 num1 = {0}", num1);
            Console.WriteLine("원본 정수 retvalue = {0}", retvalue);

            retvalue = (int)num1;
            Console.WriteLine("실수 num1 값{0}", num1);
            Console.WriteLine("정수값 retvalue {0}", retvalue);

            num1 = (float)retvalue;
            Console.WriteLine("실수 값 = {0:f5}", num1);
            //1.숫자를 문자로
            int num = 33;
            string val1;
            val1 = "" + num;
            Console.WriteLine(val1);
            //2.숫자를 문자로, 내부 함수사용
            num = 77;
            val1 = num.ToString();
            Console.WriteLine(val1);
            //3.string자료형에 내장되어있는 기능 사용
            float num2 = 3.14159f;
            val1 = string.Format("{0} {1:F2}", num, num2);
            Console.WriteLine("값1 {0}", val1);

        }
    }
}
