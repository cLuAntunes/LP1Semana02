using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string ask, ans;

            Console.Write("Ask me something!: ");
            ask = Console.ReadLine();

            switch (ask)
            {
                case "Is tomato a fruit?":
                    ans = "Yes, it is.";
                    break;
                default:
                    ans= "Sorry! I don't know about that!";
                    break;
            }

            Console.WriteLine(ans);
        }
    }
}
