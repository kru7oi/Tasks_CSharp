// Напишите алгоритм, который берет массив и перемещает все нули в конец,
// сохраняя порядок расположения остальных элементов.

var result = MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });

foreach (int i in result)
{
    Console.WriteLine(i);
}

int[] MoveZeroes(int[] array)
{
    List<int> editedArray = new List<int>();
    int length = array.Length;

    foreach (var item in array)
    {
        if (item != 0)
        {
            editedArray.Add(item);
        }
    }

    int editedArrayLength = editedArray.Count;

    for (int i = 0; i < length - editedArrayLength; i++)
    {
        editedArray.Add(0);
    }

    return editedArray.ToArray();

    // либо
    // return array.Where(x=> x != 0).Concat(arr.Where(x => x == 0)).ToArray();
}
