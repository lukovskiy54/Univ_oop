interface IItemPricing
{
    void SetPrice(double price);
}

interface IDiscountable
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
}

interface IColorable
{
    void SetColor(byte color);
}

interface ISizeable
{
    void SetSize(byte size);
}

class Book : IItemPricing, IDiscountable
{
    public void SetPrice(double price) { }
    
    public void ApplyDiscount(String discount) { }
    
    public void ApplyPromocode(String promocode) { }
   
}

class Clothing : IItemPricing, IDiscountable, IColorable, ISizeable
{
    public void SetPrice(double price) { }

    public void ApplyDiscount(String discount) { }

    public void ApplyPromocode(String promocode) { }

    public void SetColor(byte color) { }
    
    public void SetSize(byte size) { }
    
}
