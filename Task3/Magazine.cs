using System;

namespace Task3
{
    public class Magazine
    {
        private int Count { get; set; }
        private int Price { get; set; }

        public Magazine(int count, int price)
        {
            if (count <= 0)
            {
                throw new Exception("Тираж не может быть меньше или равен 0");
            }
            if (price <= 0)
            {
                throw new Exception("Цена не может быть меньше или равна 0");
            }
            Count = count;
            Price = price;
        }

        public int TotalPrice()
        {
            return Count * Price;
        }

        public override string ToString()
        {
            return $"Тираж: {Count} шт. | Цена за одну шт.: {Price}$ | Общая цена: {TotalPrice()}$";
        }
    }
}
