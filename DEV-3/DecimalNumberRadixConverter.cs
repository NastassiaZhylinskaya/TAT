using System;

namespace NumberRadixConvertion
{
  /// <summary>
  /// This class for converting decimal number
  /// to another numeral system from 2 to 20.
  /// </summary>
  public class DecimalNumberRadixConvertor
  {
    const int ASCIISYMBOL = 55;
    public int SourceNumber { get; private set; }
        
    public DecimalNumberRadixConvertor(int sourceNumber)
    {
      SourceNumber = sourceNumber;      
    }
    /// <summary>
    /// This method convert decimal number
    /// to another numeral system.
    /// </summary>
    /// <param name="radix">base numeral system.</param>
    /// <returns>converted string.</returns>
    public string ConvertTo(int radix)
    {
      int sourceNumber = SourceNumber;
      string convertedNumberString = String.Empty;
      if (0 == sourceNumber)
      {
        return sourceNumber.ToString();
      }
      while (sourceNumber > 0)
      {
        int rest = sourceNumber % radix;
        sourceNumber = sourceNumber / radix;
        int asciSymbolFirstPosition = (rest >= 10) ? ASCIISYMBOL : '0';
        convertedNumberString = (char)(asciSymbolFirstPosition + rest) + convertedNumberString;
      }
      return convertedNumberString;      
    }
  }
}
