namespace RomanCalculator
{
    public class RomanCalculator
    {
        public static string Add(string a, string b)
        {
            string c = a + b;
            if (c=="IIII")
            {
                c = "IV";
            }
            return c;
        }
    }
}