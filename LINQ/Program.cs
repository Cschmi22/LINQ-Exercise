using System.Linq;


List<string> csLewisBooks = new List<string>() { "Mere Christianity", "Surprised By Joy", "Screwtape Letters" };

csLewisBooks.Add("The Abolotion of Man");
csLewisBooks.Add("A Grief Observed");
csLewisBooks.Add("The Great Divorce");

var titleLength = csLewisBooks.OrderBy(name => name.Length);

foreach (var item in titleLength)
{
    Console.WriteLine(item);
}
