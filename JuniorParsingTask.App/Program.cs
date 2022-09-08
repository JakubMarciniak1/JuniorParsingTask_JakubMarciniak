using JuniorParsingTask;

//tree for searching
var tree = TreeService.Create();

Node node;
Console.WriteLine(tree.TryGetNode("learning", out node));

Console.ReadKey();