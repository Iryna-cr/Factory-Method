using System;

class FlowerShop
{
    public virtual string CreateFlower() => "Троянда ";
}

class TulipShop : FlowerShop
{
    public override string CreateFlower() => "Тюльпан ";
}

class Program
{
    static void Main()
    {
        FlowerShop roseShop = new FlowerShop();
        FlowerShop tulipShop = new TulipShop();

        Console.WriteLine(roseShop.CreateFlower());
        Console.WriteLine(tulipShop.CreateFlower());
    }
}



