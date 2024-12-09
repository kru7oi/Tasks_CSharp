namespace SortUri
{
    // Напишите код, который упорядочивает сбор Uri на основе своего домена следующим образом, чтобы он возвращал сначала Uri с доменами "com", "gov", "org" (в алфавитном порядке их доменов), а затем все остальные Uri, упорядоченные в алфавитном порядке их доменов верхнего уровня(TLD, часть Uri после последней точки). В дополнение к этому: содержимое Uri не должно быть изменено, остальная часть Uri не влияет на сортировку. (uri "c.com","b.com","a.com" могут быть расположены в любом порядке внутри их группы, поэтому оба "c.com", "b.com","a.com" и "a.com", "c.com","b.com" являются правильными, пока они не появятся перед*.org)

    // "http://www.google.en/?x=jsdfkj"
    // "http://www.google.de/?x=jsdfkj"
    // "http://www.google.com/?x=jsdfkj"
    // "http://www.google.com/?x=jsdfkj"
    // "http://www.google.org/?x=jsdfkj"
    // "http://www.google.gov/?x=jsdfkj"

    // =>

    // "http://www.google.com/?x=jsdfkj"
    // "http://www.google.com/?x=jsdfkj"
    // "http://www.google.gov/?x=jsdfkj"
    // "http://www.google.org/?x=jsdfkj"
    // "http://www.google.de/?x=jsdfkj"
    // "http://www.google.en/?x=jsdfkj"
    internal class UriSorter
    {
        public static IEnumerable<string> OrderByDomain(IEnumerable<string> source)
        {
            return source.OrderBy(x => !(x.Contains(".com") || x.Contains(".gov") || x.Contains(".org"))).ThenBy(x => x[x.LastIndexOf('.')..]);
        }
    }
}
