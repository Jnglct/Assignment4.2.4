namespace Assignment4._2._4
{
    internal class Program
    {
                public static void IsPalindrom(string UserString) 
        {
            UserString = UserString.ToLower();
            int L = 0;
            int R = UserString.Length - 1;
            CheckIfPalindrome(UserString,L,R);
        }
        static void CheckIfPalindrome(string UserString, int L, int R)
        {
            if (UserString[L] != UserString[R])
            {
                Console.WriteLine("The string is not Palindrome");

            }
            else if (L > R)
            {
                Console.WriteLine("The string is Palindrome");
            }
            else
            {
                ++L;
                --R;
                CheckIfPalindrome(UserString, L, R);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if it is a Palindrome");
            IsPalindrom(Console.ReadLine());
        }
    }
}
