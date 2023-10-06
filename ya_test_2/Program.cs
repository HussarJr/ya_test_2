int MinSteps(int[] arr, int k)
{
    Dictionary<int, int> NumCount = new Dictionary<int, int>();
    foreach (int i in arr)
    {
        if (NumCount.ContainsKey(i))
        {
            NumCount[i]++;
        }
        else
        {
            NumCount.Add(i, 1);
        }
    }
    if (k < 0 || k > arr.Length || k < NumCount.Count)
    {
        return -1;
    }
    else 
    {
        return arr.Length - NumCount.Values.Max();
    }
}
/*Временная сложность так же будет O(n) т.к все операции линейны и проходят по всему массиву.
 * 
 * Функция находит количество повторений для каждого элемента массива. Далее, если k не подходит по условиям, то выводит -1 т.к. в данных случаях изменить массив нельзя. 
 * В случае если k подходит по условию, то минимальное количество шагов это длинна массива - количество самого часто элемента.
 */

int[] arr = [20,20,2,2,2,3,6];
int k = 4;
Console.WriteLine(MinSteps(arr, k));