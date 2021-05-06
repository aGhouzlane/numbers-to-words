namespace NumbersToWords.Models
{
  public class NumbersToWords
  {

    public int Number { get; }
    public NumbersToWords(int number)
    {
      Number = number;
    }

    public string[] ConvertToWords()
    {
      string numberString = Number.ToString();
      int stringLength = numberString.Length;
      string[] str = new string[stringLength];

      return str;
    }
  }

}