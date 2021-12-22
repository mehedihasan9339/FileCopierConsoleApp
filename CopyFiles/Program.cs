Console.Write("Source Path: ");
var sourcePath = Console.ReadLine();
Console.Write("Destination Path: ");
var destinationPath = Console.ReadLine();
Console.Write("Extension: ");
var extension = Console.ReadLine();
Console.WriteLine();
Console.CursorVisible = false;

Console.WriteLine("{0}", 0 + " files copied!");
Console.WriteLine("{0}", 0 + " copy failed!");

var tempPath = @"C:\TempPath\";
var success = 0;
var failed = 0;

string[] allfiles = Directory.GetFiles(sourcePath + @"\", "*" + extension, SearchOption.AllDirectories);
foreach (string file in allfiles)
{
	var fileName = Path.GetFileName(file);

	if (File.Exists(file))
	{
		System.IO.File.Copy(sourcePath + @"\" + fileName, tempPath + fileName, true);
		System.IO.File.Move(tempPath + fileName, destinationPath + @"\" + fileName, true);
		success++;
		Console.SetCursorPosition(0, 4);
		Console.Write("{0}", success + " files copied!");
	}
	else
	{
		failed++;
		Console.SetCursorPosition(0, 5);
		Console.Write("{0}", failed + " copy failed!");
		Console.WriteLine(fileName);
	}
}
Console.Beep();

Console.ReadLine();
