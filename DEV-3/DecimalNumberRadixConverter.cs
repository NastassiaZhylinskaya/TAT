using System;
using System.Numerics;

namespace NumberRadixConvertion
{
  /// <summary>
  /// This class for converting decimal number
  /// to other numeral system from 2 to 20.
  /// </summary>
  public class DecimalNumberRadixConvertor
  {
    const int LATIN_SYMBOLS_START_POSITION = 55;
    public BigInteger SourceNumber { get; private set; }
        
    public DecimalNumberRadixConvertor(BigInteger sourceNumber)
    {
      SourceNumber = sourceNumber;      
    }
    /// <summary>
    /// This method converts decimal number
    /// to other numeral system.
    /// </summary>
    /// <param name="radix">base numeral system.</param>
    /// <returns>converted string.</returns>
    public string ConvertTo(int radix)
    {
      BigInteger sourceNumber = SourceNumber;
      string convertedNumberString = String.Empty;
      if (0 == sourceNumber)
      {
        return sourceNumber.ToString();
      }
      while (sourceNumber > 0)
      {
        int rest = sourceNumber % radix;
        sourceNumber = sourceNumber / radix;
        int asciSymbolFirstPosition = (rest >= 10) ? LATIN_SYMBOLS_START_POSITION : '0';
        convertedNumberString = (char)(asciSymbolFirstPosition + rest) + convertedNumberString;
      }
      return convertedNumberString;      
    }
  }
}
