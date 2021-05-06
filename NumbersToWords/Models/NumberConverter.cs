namespace NumbersToWords.Models
{
  public class NumberConverter
  {

    public int Number { get; }
    public NumberConverter(int number)
    {
      Number = number;
      string[] intervalsOfOne = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
      string[] intervalsOfTen = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
      string[] SizeDescriptor = { "hundred", "thousand", "million", "billion", "trillion" };
    }

    public void ConvertToWords()
    {
      string numberString = Number.ToString();
      //int stringLength = numberString.Length;
      string[] str = new string[numberString.Length];

      for (int i = numberString.Length; i > 0; i--)
      {
        System.Console.WriteLine(str[i]);
      }
    }



  }

}