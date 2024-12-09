internal class Program
{
    private static void Main(string[] args)
    {
        string str = "asd";
        string str1 = "asd";
        int a, b, c;
        double d = 5.7;
        a = b = 5;
        Method1(a, b);
        Method2();
        Method3(false);
        Method4(new char[] { '4', 's', 'f' });
        Method5("", "", true);
        Method6(3, 5, 6);
        Method7(ref d);
        Method8(ref str, ref str1);
        Method9();
        Method10(3, 4, 5, 10);
        Method11(ref a, ref b, out c);
        Method12(ref str, 's', out a, out a, 1, 2, 3);
    }


    private static void Method1(int a, int b)
    {

    }
    private static string Method2()
    {
        return "";
    }
    private static void Method3(bool isActive)
    {

    }
    private static string Method4(char[] characters)
    {
        return "";
    }
    private static int Method5(string a, string b, bool isAlive)
    {
        return 0;
    }
    private static string Method6(int a, int b, int c)
    {
        return "";
    }
    private static void Method7(ref double a)
    {

    }
    private static bool Method8(ref string str1, ref string str2)
    {
        return true;
    }
    private static void Method9()
    {
        LocalMethod1('a', 'b');

        int LocalMethod1(char a, char b)
        {
            return 0;
        }
    }
    private static double Method10(params int[] numbers)
    {
        return 5.7;
    }
    private static void Method11(ref int a, ref int b, out int c)
    {
        c = 5;
    }
    private static bool Method12(ref string s, char c, out int n1, out int n2, params int[] arr)
    {
        n2 = n1 = 0;

        return true;
    }
   
}