

namespace FormatingTextApp_Structural
{
    public class UnderlinedText : BaseDecorator
    {
        public UnderlinedText(IFormatText text) : base(text) { }
        public override string FormatText()
        {
            return _text.FormatText() + " underline";
        }
    }
}
