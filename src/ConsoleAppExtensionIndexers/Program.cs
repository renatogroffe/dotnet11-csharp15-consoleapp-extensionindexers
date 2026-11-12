using System.Runtime.InteropServices;
using ConsoleAppExtensionIndexers.Extensions;

Console.WriteLine("***** Testes com .NET 11 + C# 15 | Extension Indexers *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

Console.WriteLine("Copas vencidas pelo Brasil...");
IEnumerable<int> vitoriasEmCopas = [1958, 1962, 1970, 1994, 2002];
for (int i = 0; i < vitoriasEmCopas.Count(); i++)
{
    Console.WriteLine($"{i + 1}a Copa = {vitoriasEmCopas[i]}");
}