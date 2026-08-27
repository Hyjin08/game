using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0827
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cast.CastInt();
            Statements.Ternary();
            Statements.LoopFor();
        }
    }
    internal class Cast
    {
        public static void CastInt()
        {
            string val = "33";
            String val1 = "3.14";
            //문자를 숫자로
            int ret = 0;
            float ret1 = 0;
            //1.자료형 별로 문자열 변환함수가 있다.
            ret = int.Parse(val);
            Console.WriteLine("정수값" + ret);
            ret1 = float.Parse(val);
            Console.WriteLine("실수값1" + ret);
            double ret2 = double.Parse(val1);
            Console.WriteLine("실수값2" + ret2);

            //변환전용 함수를 사용한다
            Console.WriteLine("");
            ret = Convert.ToInt32(val);
            ret1 = Convert.ToSingle(val1);//문자를 float 값으로
            Console.WriteLine("결과{0:F4}", ret1);
        }
    }   
    internal class ObjectType
    {
        public static void Boxing()
        {
            object box = 50;
            Console.WriteLine("박싱값: {0}", box);

            int unboxed = (int)box;
            Console.WriteLine("언박싱 값: {0}", unboxed);
            //2단계: 언박싱된 값을 바탕으로 연산
            unboxed += 5;
            Console.WriteLine("언박싱 계산 결과: {0}", unboxed);

        }
    }
    internal class Statements
    {
        public static void Ternary()
        {
            //String num = Console.ReadLine();
            //int num1 = int.Parse(num);
            //int abs;
            //절대값 연산(삼항 연산자 사용)
            //abs = (num1 > 0) ? num1 : num1 * (-1);
            //Console.WriteLine(num + "절대값=" + abs);
        }

        public static void LoopWhile()
        {
            int count = 0;
            Console.WriteLine("현재 카운트값: {0}", count);
            while (count < 5)
            {
                Console.WriteLine("반복" + count);
                count++;
            }
            Console.WriteLine("반복 완료");
        }
        public static void LoopFor()
        {
            Console.WriteLine("출력하고자 하는 구구단의 단: ");
            string input_str = Console.ReadLine();
            int inputdan = int.Parse(input_str);

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", inputdan, i, i * inputdan);
            }
            Console.WriteLine("");
            //2단에서 9단까지 구구단 출력
            for (int i = 2; i <= 9; i++) //2, 3, 4, 5, 6, 7, 8, 9
            {
                Console.WriteLine("{0} 단 출력", i);
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
                Console.WriteLine("");
            }
        }
        public static void Control()
        {
            int i = 0;
            for (i = 0; i < 10; i++) //0~9 10번 반복
            {
                if (i == 8)
                    break;
                if (i == 3)
                    continue;

                Console.WriteLine(i);
            }
        }
    }
}




