

namespace FormatingTextApp_Structural
{
    public static class TextFormatter
    {
        public static IFormatText Italic()
        {
            IFormatText formattedText = new WriteText();
            formattedText = new ItalicText(formattedText);
            return formattedText;
        }
        public static IFormatText ItalicBolded()
        {
            IFormatText formattedText = new WriteText();
            formattedText = new ItalicText(formattedText);
            formattedText = new BoldText(formattedText);
            return formattedText;
        }

        public static IFormatText ItalicBoldedUnderlined()
        {
            IFormatText formattedText = new WriteText();
            formattedText = new ItalicText(formattedText);
            formattedText = new BoldText(formattedText);
            formattedText = new UnderlinedText(formattedText);
            return formattedText;
        }

        public static IFormatText ItalicBoldedUnderlinedColored()
        {
            IFormatText formattedText = new WriteText();
            formattedText = new ItalicText(formattedText);
            formattedText = new BoldText(formattedText);
            formattedText = new UnderlinedText(formattedText);
            formattedText = new ColoredText(formattedText);
            return formattedText;
        }
    }
}
