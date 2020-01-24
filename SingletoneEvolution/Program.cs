using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Type1.staticInt);

            //Type1 Type1 = new Type1();
            Console.Write(Type1.staticInt);

            Type2 type2 = new Type2();
            Console.Write(type2.regularInt);

            Type3 type3 = new Type3();
            Console.Write(type3.type1);

            Console.Write(type3.type2.regularInt);

            Console.Write(Type4.type1);
            Console.Write(Type4.type2.regularInt);

            Console.Write(Type5.staticInt);
            Console.Write(Type5.type5.regularInt);

            Console.Write(Type6.GetInstance().regularInt);

            Console.Write(Type7.GetInstance().regularInt);
        }
    }

    public class Type1
    {
        public static int staticInt = 0;
    }

    public class Type2
    {
        public int regularInt = 0;
    }

    public class Type3
    {
        public Type1 type1 = new Type1();
        public Type2 type2 = new Type2();
    }

    public class Type4
    {
        public static Type1 type1 = new Type1();
        public static Type2 type2 = new Type2();
    }

    public class Type5
    {
        public static int staticInt = 0;
        public static Type5 type5 = new Type5();

        public int regularInt = 0;
    }

    public class Type6
    {
        private static Type6 _instance = new Type6();
        public static Type6 GetInstance()
        {
            return _instance;
        }

        public int regularInt = 0;
    }

    public class Type7
    {
        private static Type7 _instance;
        public static Type7 GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Type7();
            }
            return _instance;
        }

        public int regularInt = 0;
    }


}
