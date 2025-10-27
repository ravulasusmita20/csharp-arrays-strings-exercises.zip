string url = Console.ReadLine()!;
string protocol = "", server = "", resource = "";
int protoSep = url.IndexOf("://", StringComparison.Ordinal);
int start = 0;
if (protoSep >= 0) { protocol = url[..protoSep]; start = protoSep + 3; }
int slash = url.IndexOf('/', start);
if (slash >= 0) { server = url[start..slash]; resource = url[(slash + 1)..]; }
else { server = url[start..]; resource = ""; }
Console.WriteLine($"[protocol] = "{protocol}"");
Console.WriteLine($"[server] = "{server}"");
Console.WriteLine($"[resource] = "{resource}"");
