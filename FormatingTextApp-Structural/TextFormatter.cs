

namespace FormatingTextApp_Structural
{
    public static class TextFormatter
    {
        public static IFormatText ItalicBolded(string text)
        {
            IFormatText formattedText = new WriteText(text);
            formattedText = new ItalicText(formattedText);
            formattedText = new BoldText(formattedText);
            return formattedText;
        }

        public static IFormatText ItalicBoldedUnderlined(string text)
        {
            IFormatText formattedText = new WriteText(text);
            formattedText = new ItalicText(formattedText);
            formattedText = new BoldText(formattedText);
            formattedText = new UnderlinedText(formattedText);
            return formattedText;
        }

        public static IFormatText ItalicBoldedUnderlinedColored(string text)
        {
            IFormatText formattedText = new WriteText(text);
            formattedText = new ItalicText(formattedText);
            formattedText = new BoldText(formattedText);
            formattedText = new UnderlinedText(formattedText);
            formattedText = new ColoredText(formattedText);
            return formattedText;
        }
    }
}
