using BenchmarkDotNet.Running;
using BenchmarkTest;

Console.WriteLine("### Usando BenchmarkDotNet  ###\n");
Console.WriteLine("Pressione algo para iniciar\n");
Console.ReadLine();
var resultado = BenchmarkRunner.Run<QueryBenchmark>();