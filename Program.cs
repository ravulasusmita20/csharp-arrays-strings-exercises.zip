int[] src = { 3, 5, 8, 13, 21, 34, 55, 89, 144, 233 };
int[] dst = new int[src.Length];
for (int i = 0; i < src.Length; i++) dst[i] = src[i];
Console.WriteLine("src: " + string.Join(", ", src));
Console.WriteLine("dst: " + string.Join(", ", dst));
