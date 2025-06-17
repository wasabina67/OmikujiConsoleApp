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

Console.Write("🙏 Drawing a fortune");
for (int i = 0; i < 3; i++)
{
    Thread.Sleep(500);
    Console.Write(".");
}
Thread.Sleep(500);
Console.WriteLine("\n");

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
ConsoleColor[] colors = {
    ConsoleColor.Yellow,
    ConsoleColor.Yellow,
    ConsoleColor.Green,
    ConsoleColor.Green,
    ConsoleColor.Blue,
    ConsoleColor.DarkYellow,
    ConsoleColor.Red
};

Random random = new Random();
int index = random.Next(fortunes.Length);
Console.WriteLine("📜 Your fortune is");
Thread.Sleep(1000);

Console.ForegroundColor = colors[index];
Console.WriteLine("");
Console.WriteLine($"{emojis[index]} {fortunes[index]} {emojis[index]}");
Console.WriteLine("");
Console.ResetColor();

Console.WriteLine($"💡 {advice[index]}");
