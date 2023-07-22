void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length) {
        collection [index] = new Random().Next (1, 10);
        index++;
    }

}


void PrintArray (int [] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count) {
        Console.WriteLine (col[position]);
        position++;
    }


}
//int [] array = new int [10];

//int n = array.Length;
//int find = 4;
//int index = 0;

//while (index < n) 
//{
//    if (array[index] == find) 
//    {
//        Console.WriteLine(index);
//        break;
//    }
//   index++;
//}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int possition = -1;
    while (index < count) {
        if (collection [index] == find) {
            possition = index;
            break;

        }
        index++;
    }
    return possition;
}


int [] array = new int[10];



FillArray (array);
array [4] = 4;
array [6] = 4;   
PrintArray (array);
Console.WriteLine ();
int pos = IndexOf (array, 444);
Console.WriteLine (pos);    



