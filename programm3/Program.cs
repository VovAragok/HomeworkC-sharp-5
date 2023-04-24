// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3,21 7,04 22,93 -2,71 78,24] -> 80,95


void   dataInput()
{

    Console.WriteLine(" Какой будет  размер массива? ");
    int size =  revisorInt();
    Console.WriteLine(" Какой будет  минимальный диапозон массива? - ");
    double minValue =  revisor();
    Console.WriteLine("какой будет  максимальный размер массива? " );
    double maxValue = revisor ();
    Console.WriteLine("Ваш случайный массив:");
    double [] randomArr = RandommaArray(size, minValue, maxValue);
    double result = maxdouble(randomArr) - mindouble(randomArr);
    Console.WriteLine($"разница между максимальным и минимальным элементами массива = {result}");
    

    
    



}


double revisor()
{ 
    double number;

    while(true)
    {
        Console.WriteLine("Введите вещественное число:");
        string s1 = Console.ReadLine();
        if (double.TryParse(s1, out number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Ошибка ввода.");
        }
    }
}

int revisorInt()
{ 
    int number;

    while(true)
    {
        Console.WriteLine("Введите число:");
        string s1 = Console.ReadLine();
        if (int.TryParse(s1, out number))
        {
            if (number >1 )
            {
                return number;
            }
            else
            {
                Console.WriteLine("размер массива не может быть таким!!!");

            }
            
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Это не число!");
        }
    }
}

double [] RandommaArray(int size, double minValue , double maxValue)  
{
     double[] numbers = new double [size];
     Random  rnd = new Random();

     for (int i = 0; i < size; i++)
     {
         numbers[i] = minValue + (maxValue - minValue) * rnd.NextDouble();
        
         
     }
    string joinArr = string.Join(", ", numbers);
    Console.WriteLine(joinArr);
     return numbers;

}



double mindouble(double[] array)
{
    int size  = array.Length;
    double min = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i]< min)
        {
            min = array[i];

        }
    }
    Console.WriteLine($"минимальное чилсо массива = {min}");
    return min;
}


double maxdouble(double[] array)
{
    int size  = array.Length;
    double max = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i]> max)
        {
            max = array[i];

        }
    }
    Console.WriteLine($"максимальное  чилсо массива = {max}");
    return max;
}




dataInput();






