using PaginationHelper;

internal class Program
{
    // Выполняя это упражнение, вы укрепите свое мастерство в пейдж-фу.
    // Вы создадите класс PaginationHelper, который является служебным классом, 
    // полезным для запроса информации о подкачке, относящейся к массиву.
    // Класс предназначен для приема массива значений и целого числа, указывающего,
    // сколько элементов будет разрешено на каждой странице.
    // Типы значений, содержащихся в коллекции/массиве, не имеют отношения к делу.

    // Ниже приведены некоторые примеры того, как используется этот класс:

    // var helper = new PaginationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f' }, 4);
    // helper.PageCount; // should == 2
    // helper.ItemCount; // should == 6
    // helper.PageItemCount(0); // should == 4
    // helper.PageItemCount(1); // last page - should == 2
    // helper.PageItemCount(2); // should == -1 since the page is invalid

    //// pageIndex принимает индекс элемента и возвращает страницу, к которой он принадлежит
    // helper.PageIndex(5); // should == 1 (zero based index)
    // helper.PageIndex(2); // should == 0
    // helper.PageIndex(20); // should == -1
    // helper.PageIndex(-10); // should == -1
    private static void Main(string[] args)
    {
        PaginationHelper<char> paginationHelper = new PaginationHelper<char>(new List<char> { 'a', 'b', 'c', 'd', 'e', 'f'}, 4);

        Console.WriteLine(paginationHelper.PageCount);
        Console.WriteLine(paginationHelper.ItemCount);
        Console.WriteLine(paginationHelper.PageItemCount(0));
        Console.WriteLine(paginationHelper.PageItemCount(1));
        Console.WriteLine(paginationHelper.PageItemCount(2));

        Console.WriteLine(paginationHelper.PageIndex(5));
        Console.WriteLine(paginationHelper.PageIndex(2));
        Console.WriteLine(paginationHelper.PageIndex(20));
        Console.WriteLine(paginationHelper.PageIndex(-10));
    }
}