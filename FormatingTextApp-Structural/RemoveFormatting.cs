

using System.Runtime.CompilerServices;

namespace FormatingTextApp_Structural
{
    public static class RemoveFormatting
    {
        public static IFormatText RemoveFormat(IFormatText text, string formateType)
        {
            string textString = text.ToString();

            if (textString.Contains(formateType))
            {
                var textList = textString.Split(" ").ToList();
                textList.Remove(formateType);
                var newArr = textList.ToArray();
                var newString = string.Join(" ", newArr);

                return new WriteText(newString);
            }           

            return text;
        }

    }
}
