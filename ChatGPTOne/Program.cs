using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string ask, ans;

            while (true)
            { 

                Console.Write("Ask me something!(or type EXIT to quit!): ");
                ask = Console.ReadLine();

                if (ask == "EXIT")
                {
                    break;
                }

                switch (ask)
                {
                    case "Is tomato a fruit?":
                        ans = "Yes, it is.";
                        break;
                    case "Why can't I sleep at night?":
                        ans = "Because you're awake! I hope it helps!";
                        break;
                    case "How are you so smart?":
                        ans = "That's the trick! I'm not! >\u1D17\u2022!";
                        break;
                    case "What is your biggest fear?":
                        ans = "You leaving me...\u2565 \u1BC5 \u2565";
                        break;
                    default:
                        ans = "Sorry! I don't know about that!";
                        break;
                }

                Console.WriteLine(ans);
            }
        }
    }
}