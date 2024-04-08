

namespace FormatingTextApp_Structural
{
    public class WriteText : IFormatText
    {
        public string Text { get; set; }
        public WriteText(string text)
        {
            Text = text;
        }

      public string FormatText()
        {
            Console.WriteLine(Text);
            return Text;
        }
    }
}
