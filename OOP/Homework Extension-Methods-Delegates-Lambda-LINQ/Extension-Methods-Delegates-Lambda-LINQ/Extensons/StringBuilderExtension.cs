using System.Text;
namespace Extension_Methods_Delegates_Lambda_LINQ
{
    public static class StringBuilderExtension
    {
         public static StringBuilder Substring(this StringBuilder strBuilder , int index ,int lenght)
        {
            string strBuilderInString = strBuilder.ToString();
            StringBuilder result = new StringBuilder(lenght);
            for (int i = index ; i < index+ lenght; i++)
            {
                result.Append(strBuilderInString[i]);
            }
            return result;
        }
    }
}
