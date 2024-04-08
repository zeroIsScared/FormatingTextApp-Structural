

namespace FormatingTextApp_Structural
{
    public class ItalicText : BaseDecorator
    {
        public ItalicText(IFormatText text) : base(text) 
        {
            
        }
        public override string FormatText()
        {
            return _text.FormatText() + " italic";
        }
    }
}
