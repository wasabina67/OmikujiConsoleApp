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
