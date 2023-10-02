namespace Converter;

class Converter
{
    private readonly decimal USD;

    private readonly decimal EUR;

    private static void ValidateAmount(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Exchange rate can not be 0 or negative", nameof(amount));
        }
    }

    public Converter(decimal Usd, decimal Eur)
    {
        if (Usd <= 0)
        {
            throw new ArgumentException("Exchange rate can not be 0 or negative", nameof(Usd));
        }
        if (Eur <= 0)
        {
            throw new ArgumentException("Exchange rate can not be 0 or negative", nameof(Eur));
        }
        this.USD = Usd;
        this.EUR = Eur;
    }

    public decimal ConvertUANToEUR(decimal UAN) {
        ValidateAmount(UAN);
        return UAN / this.EUR;
    }

    public decimal ConvertUANToUSD(decimal UAN) {
        ValidateAmount(UAN);
        return UAN / this.USD;
    }

    public decimal ConvertEURToUAN(decimal EUR) {
        ValidateAmount(EUR);
        return EUR * this.EUR;
    }

    public decimal ConvertUSDToUAN(decimal USD) {
        ValidateAmount(USD);
        return USD * this.USD ; 
    }
}
