using LinkedListLibrary;

var list = new Mylinkedlist<int>();


list.AddFirst(3);
list.AddFirst(2);
list.AddFirst(1);
Console.WriteLine("AddFirst 1,2,3: " + string.Join(", ", list));
Console.WriteLine("Count: " + list.Count);
Console.WriteLine("Head: " + list.Head!.Value);
Console.WriteLine("Tail: " + list.Tail!.Value);


list.AddLast(4);
list.AddLast(5);
Console.WriteLine("After AddLast 4,5: " + string.Join(", ", list));
Console.WriteLine("Tail: " + list.Tail!.Value);


var col = (ICollection<int>)list;
Console.WriteLine("Contains 3: " + col.Contains(3));
Console.WriteLine("Contains 9: " + col.Contains(9));


list.RemoveFirst();
Console.WriteLine("After RemoveFirst: " + string.Join(", ", list));
Console.WriteLine("Head: " + list.Head!.Value);


list.RemoveLast();
Console.WriteLine("After RemoveLast: " + string.Join(", ", list));
Console.WriteLine("Tail: " + list.Tail!.Value);

col.Clear();
Console.WriteLine("After Clear, Count: " + list.Count);
Console.WriteLine("Head is null: " + (list.Head == null));


list.AddFirst(42);
Console.WriteLine("Single element Head==Tail: " + (list.Head == list.Tail));
list.RemoveLast();
Console.WriteLine("After RemoveLast single, Count: " + list.Count);