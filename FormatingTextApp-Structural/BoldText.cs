

namespace FormatingTextApp_Structural
{
    public class BoldText : BaseDecorator
    {
        public BoldText(IFormatText text) : base(text) { }
        public override string FormatText()
        {
            return _text + " bold";
        }
    }
}
