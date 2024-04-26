namespace Static_Class
{
    internal class Static_Understand
    {

        public static class MyUtility
        {
            private static int ver;

            // static 생성자
            static MyUtility()
            {
                ver = 1;
            }

            public static string Convert(int i)
            {
                return i.ToString();
            }

            public static int ConvertBack(string s)
            {
                return int.Parse(s);
            }
        }

        static void Main(string[] args)
        {
            string str = MyUtility.Convert(123);
            int i = MyUtility.ConvertBack(str);
            Console.WriteLine(i);
        }
    }
}
