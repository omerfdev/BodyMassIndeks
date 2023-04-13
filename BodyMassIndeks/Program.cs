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
    int entrytime = DateTime.Now;
    Console.WriteLine("\n" + DateTime.Now);
    tımenow = false;
}


OMERFDEV:
int height, weigth, bmi;


height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter Your Weigth");
weigth = Convert.ToInt32(Console.ReadLine());
bmi = (weigth / ((height * height) / 10000));
if (bmi <= 18)
{
    Console.WriteLine("Weak");
    goto OMERFDEV;
}
else if (bmi >= 18 && bmi < 25)
{
    Console.WriteLine("Normal");
    goto OMERFDEV;
}
else if (bmi >= 25 && bmi < 30)
{
    Console.WriteLine("Fat");
    goto OMERFDEV;
}
else if (bmi >= 30 && bmi < 35)
{
    Console.WriteLine("Obese");
    goto OMERFDEV;
}
else
{
    Console.WriteLine("Serious Obese");
    goto OMERFDEV;
}
