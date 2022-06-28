int[] array = {23, 56, 46, 45, 44, 35, 44, 56, 47, 30};
int n = array.Length;

Console.Write("Введите искомое число :");
int num = Convert.ToInt32(Console.ReadLine());
int index = 0;

while(index < n)
{
    if (array[index] == num)
    {
        Console.Write("Индекс нужного элемента :"+ index);
        break;
        //index++;
    }
    index++;
}