using System;
using System.Threading;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Title = "🎋 Omikuji Console App 🎋";

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("========================================");
Console.WriteLine("🎋✨ Welcome to Omikuji Console App ✨🎋");
Console.WriteLine("========================================");
Console.ResetColor();

Console.WriteLine("");
Console.WriteLine("🙏 Drawing a fortune 🙏");
for (int i = 0; i < 3; i++)
{
    Thread.Sleep(500);
    Console.Write(".");
}
Thread.Sleep(500);
Console.WriteLine("");

string[] fortunes = { "大吉", "吉", "中吉", "小吉", "末吉", "凶", "大凶" };
string[] emojis = { "🌟🌟🌟", "🌟🌟", "🌟", "✨", "🍀", "☁️", "⚡" };
string[] advice = {
    "1",
    "2",
    "3",
    "4",
    "5",
    "6",
    "7"
};

Random random = new Random();
int index = random.Next(fortunes.Length);
Console.WriteLine("📜 Your fortune is...");
Thread.Sleep(1000);
