using LinkedList;

// See https://aka.ms/new-console-template for more information
var linkedList = new LinkedListExample<int>();
linkedList.Append(1);
Console.WriteLine(linkedList.Head().value);
linkedList.Append(2);
linkedList.Prepend(3);
Console.WriteLine(linkedList.Head().value);
Console.WriteLine(linkedList.Size());
Console.WriteLine(linkedList.At(linkedList.Size() - 1).value);
Console.WriteLine(linkedList.Tail().value);
linkedList.Pop();
Console.WriteLine(linkedList.Tail().value);
