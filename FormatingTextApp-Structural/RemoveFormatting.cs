

using System.Runtime.CompilerServices;

namespace FormatingTextApp_Structural
{
    public static class RemoveFormatting
    {
        public static IFormatText RemoveFormat()
        {
            IFormatText bareText = new WriteText();
            return bareText;
        }
    }
}
