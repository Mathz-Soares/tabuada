Console.WriteLine("de qual numero deseja ver a tabuada?");
    int numero = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------");
for (int i = 0; i <= 10; i++)
{     
    int tabuada = numero * i;
    Console.WriteLine("{0} x {1} = {2}",numero, i, tabuada);
}
