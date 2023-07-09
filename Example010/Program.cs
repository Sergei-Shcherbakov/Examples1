// int [] array = {15,26,18,84,18,60,70,68};
// int n = array.Length;
// int find = 18;
// int index = 0;
// while (index<n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         index++;
//         break;
//     }
// }

int [] array = {15,26,18,84,18,60,70,68};
int n = array.Length;
int find = 18;
int index = 0;
while (index<n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    
        break;
    }
    index++;
}
