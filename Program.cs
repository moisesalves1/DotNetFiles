﻿using System.IO;

IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("Tailwind\\stores");

foreach (var dir in listOfDirectories) {
    Console.WriteLine(dir);
}

// Outputs:
// stores/201
// stores/202

Console.WriteLine("--------------------------------------------");

IEnumerable<string> files = Directory.EnumerateFiles("Tailwind\\stores");

foreach (var file in files)
{
    Console.WriteLine(file);
}

// Outputs:
// stores/totals.txt
// stores/sales.json

Console.WriteLine("--------------------------------------------");
// Find all *.txt files in the stores folder and its subfolders
IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("Tailwind\\stores", "*.txt", SearchOption.AllDirectories);

foreach (var file in allFilesInAllFolders)
{
    Console.WriteLine(file);
}

// Outputs:
// stores/totals.txt
// stores/201/inventory.txt