int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int [] array = {1, 2, 306, 4, 5, 6, 75, 8, 9};

array[0] = 12;

Console.WriteLine(array[4]);
int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.WriteLine(max);

int[] arr = {1, 2, 3, 4, 8, 6, 7, 8};
int n = arr.Length;
int find = 8;
int index = 0;
while (index < n)
{
  if (arr[index] == find)
  {
    Console.WriteLine(index);
    break;
  }
  index++;  
}


