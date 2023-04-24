// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void   dataInput()
{

    Console.WriteLine(" Какой будет  размер массива? ");
    int size =  revisor();
    Console.WriteLine(" Какой будет  минимальный диапозон массива? - ");
    int minValue =  revisor();
    Console.WriteLine("какой будет  максимальный размер массива? " );
    int maxValue = revisor ();
    int [] randomArr = RandommaArray(size, minValue, maxValue);
    sumOddIndex(randomArr);
    



}


int  revisor()
{ 
    int number;

    while(true)
    {
        Console.WriteLine(" Введите число ");
        string s1 = Console.ReadLine();
        if (int.TryParse(s1, out number))
            {
                return number;
            }
        else
            {
                Console.WriteLine("Ошибка ввода.");
            }
         }
}


int [] RandommaArray(int size , int minValue, int maxValue) 
{
     int[] numbers = new int [size];
     Random  rnd = new Random();

     for (int i = 0; i < size; i++)
     {
         numbers[i] = rnd.Next(minValue, maxValue + 1);
         
         
     }
    string joinArr = string.Join(", ", numbers);
    Console.WriteLine(joinArr);
    return numbers;
     

}



void  sumOddIndex(int[] array)
{
    int size  = array.Length;
    int sumIndex =0 ;
    for (int i = 0; i < size; i++)
    {
        if  (i  % 2 != 0)
            {
                
                sumIndex += array[i];
                
                
            }
        
    }
    Console.WriteLine($"сумма чисел нечетных индексов в массиве  = {sumIndex}");
    

}


dataInput();