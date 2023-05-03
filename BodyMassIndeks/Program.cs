using System.ComponentModel.Design;
using System.Diagnostics;
using System.Xml;

bool tımenow = true;
for (int i = 0; i < 100; i++)
{
    Console.Write("*");
    if (i == 99)
    {
        Console.WriteLine("\nWelcome To Body Mass Index");
        for (int a = 100; a > 0; a--)
        {
            Console.Write("*");
            while (a == 0)
            {
                Console.WriteLine("\nPlease Enter Your Height");
            }
        }
    }
}
while (tımenow)
{
    DateTime dateTime = DateTime.Now;
    Console.WriteLine("\n" + DateTime.Now);
    tımenow = false;
}
double height = 0; double weigth = 0; double bodyMassIndex;

try
{
    Console.WriteLine("Please Enter Your Heigth");
    height = double.Parse(Console.ReadLine());
    Console.WriteLine("Please Enter Your Weigth");
    weigth = double.Parse(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine(ex);

}
finally { bodyMassIndex = (weigth / (Math.Pow(height, 2))); }
if (bodyMassIndex <= 18.5)
{
    Console.WriteLine("Below the ideal weigth");
    OpenBrowser("https://youtu.be/XMcab1MFaLc");

}
else if (bodyMassIndex <= 24.9)
{
    Console.WriteLine("ideal weigth");
    OpenBrowser("https://youtu.be/XMcab1MFaLc");
}
else if (bodyMassIndex <= 29.9)
{
    Console.WriteLine("Above the ideal weigth");
    OpenBrowser("https://youtu.be/XMcab1MFaLc");
}
else if (bodyMassIndex <= 39.9)
{
    Console.WriteLine("obese");
    
    OpenBrowser("https://youtu.be/XMcab1MFaLc");
}
else
{
    Console.WriteLine("Morbidly Obese");
    
    OpenBrowser("https://youtu.be/XMcab1MFaLc");
}
Console.ReadLine();

static void OpenBrowser(string url)
{
    Console.WriteLine("Redirecting To Link...");
    Thread.Sleep(2000);
    Process.Start(new ProcessStartInfo
    {
        FileName = url,
        UseShellExecute = true
    });

}