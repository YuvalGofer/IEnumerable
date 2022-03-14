using System.Collections;
//
C c1 = new C();
//using IEnumerable interface
foreach (var item in F1())
    Console.WriteLine(item);
//using class IEnumerator
foreach (var item in c1)
    Console.WriteLine(item);
foreach (var item in c1.GetFood())
    Console.WriteLine(item);
//using IEnumerable generic interface
foreach (var item in F2())
    Console.WriteLine(item);
////definitions:
IEnumerable F1()
{    
    yield return "H";
    yield return "e";
    yield break;
    yield return "l";
    yield return "l";
    yield return "o";
}
//
IEnumerable<string> F2()
{
    yield return "W";
    yield return "o";
    yield break;
    yield return "r";
    yield return "l";
    yield return "d";
}
IEnumerable<int> GetRange(int from, int to)
{
    for (int i = from; i < to; i++){
        yield return i;
    }
}
//
class C
{
    public IEnumerator GetEnumerator()
    {
        yield return 1;
        yield return 2;
        yield return 3;
        yield return 4;
    }

    public IEnumerable GetFood()
    {
        yield return "P";
        yield return "i";
        yield return "t";
        yield return "t";
        yield return "z";
        yield return "a";
    }
}