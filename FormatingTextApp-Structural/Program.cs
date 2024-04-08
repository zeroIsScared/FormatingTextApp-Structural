// See https://aka.ms/new-console-template for more information
using FormatingTextApp_Structural;



IFormatText formattedText = new WriteText();
var formattedText1 = new ItalicText(formattedText);
var newText = TextFormatter.ItalicBoldedUnderlined().FormatText();
Console.WriteLine(formattedText1.FormatText());
Console.WriteLine(TextFormatter.ItalicBoldedUnderlined().FormatText());
Console.WriteLine(TextFormatter.ItalicBoldedUnderlinedColored().FormatText());
Console.WriteLine(RemoveFormatting.RemoveFormat().FormatText());