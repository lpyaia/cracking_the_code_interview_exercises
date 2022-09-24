using Common;

Console.WriteLine("enter all projects: ");
var projectsInput = Console.ReadLine();
var projects = projectsInput.Split(',');

Console.WriteLine("enter depencies: ");
var depsInput = Console.ReadLine();
var deps = depsInput.Split(' ');

Graph<string> g = new();

foreach (var p in projects)
{
    g.AddNode(p);
}

Console.WriteLine();

foreach (var dep in deps)
{
    var splittedDep = dep.Split(',');

    var dependency = g.GetNode(splittedDep[0]);
    var dependent = g.GetNode(splittedDep[1]);

    dependent.AddNeighbor(dependency);
}

Console.WriteLine(g.BuildOrder());