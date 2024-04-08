

namespace FormatingTextApp_Structural
{
    public abstract class BaseDecorator : IFormatText
    {
        protected IFormatText _text;

        public BaseDecorator(IFormatText text)
        {
            _text = text;
        }

        public abstract string FormatText();
    }
}
