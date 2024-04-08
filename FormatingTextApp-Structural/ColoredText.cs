
namespace FormatingTextApp_Structural
{
    internal class ColoredText : BaseDecorator
    {
        public ColoredText(IFormatText text) : base(text) { }   
        public override string FormatText()
        {
            return _text.FormatText() + " color";
        }
    }
}
