using SortUri;

var source = new[] {
          "http://www.google.en/?x=jsdfkj",
          "http://www.google.de/?x=jsdfkj",
          "http://www.google.com/?x=jsdfkj",
          "http://www.google.com/?x=jsdfkj",
          "http://www.google.org/?x=jsdfkj",
          "http://www.google.gov/?x=jsdfkj",
      };

var result = UriSorter.OrderByDomain(source);


foreach (var item in result)
{
    Console.WriteLine(item);
}
