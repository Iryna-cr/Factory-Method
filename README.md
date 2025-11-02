# Factory-Method

Ідея фабричного методу: 

створення об’єктів через спеціальний метод, а не напряму через new.

Як працює код: 

є базовий клас із методом Create(), який повертає об’єкт. Підкласи перевизначають цей метод, щоб створювати конкретні типи об’єктів (наприклад, різні квіти).

Навіщо: 

дозволяє легко додавати нові типи, не змінюючи існуючий код.

## Код
```csharp
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
```
## Результат
![Результат виконання](sc1.png)
