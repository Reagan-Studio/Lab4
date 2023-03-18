using Lab4;


DymArray v1 = new DymArray();
DymArray v2 = new DymArray(31);
var arr = new double[] { 5, 7, 8, 9, 0, 3, 8, 9 };
DymArray v3 = new DymArray(arr);

//Console.WriteLine($"\nv1: " + v1);
//Console.WriteLine($"\nv2: " + v2);
//Console.WriteLine($"\nv3: " + v3);

Console.WriteLine($"\nЧисло действительных элемeнтов в v3 = {v3.Count}");
v3[0] = 56;
Console.WriteLine("\nv3[0] = " + v3[0]);
v2.AppendToEnd(67);
v2.AppendToEnd(67);
v2.AppendToEnd(67);
v2.AppendToEnd(67);
Console.WriteLine("\nv2: " + v2);
v2.DeleteTail();
Console.WriteLine("\nv2: " + v2);
v3.Insert(10000, 4);
Console.WriteLine("\nv3: " + v3);
v3.RemoveAt(4);
Console.WriteLine("\nv3: " + v3);
v3.RemoveAll(8);
Console.WriteLine("\nv3: " + v3);
Console.WriteLine("\nИндекс максимального значения v3 = " + v3.MaxIndex());


