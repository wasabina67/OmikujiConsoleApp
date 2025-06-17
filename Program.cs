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
    "今日はとても幸運な日です。新しいことに挑戦してみましょう！",
    "順調な日になりそうです。感謝の気持ちを忘れないでください。",
    "まずまずの運勢です。焦らず着実に進めましょう。",
    "小さな幸せに恵まれる日です。周りの人に親切にしましょう。",
    "平凡な一日ですが、工夫次第で良い日になります。",
    "少し注意が必要な日です。慎重に行動しましょう。",
    "困難に直面するかもしれません。無理はせず休息を取りましょう。"
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

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("");
Console.WriteLine("=======================");
Console.WriteLine("🎋✨ See you again ✨🎋");
Console.WriteLine("=======================");
Console.ResetColor();

Console.WriteLine("\nPress Enter to finish...");
Console.ReadLine();
