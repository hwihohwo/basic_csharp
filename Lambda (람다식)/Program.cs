using System;

namespace Lambda
{

    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare,
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }

    class Program
    {
        static List<Item> _items = new List<Item>();

        delegate Return MyFunc<T, Return>(T item);
        // delegate를 직접 선언하지 않아도, 이미 만들어진 애들이 존재한다.
        // -> 반환 타입이 있을 경우 Func
        // -> 반환 타입이 없으면 Action

        static Item FindItem(MyFunc<Item, bool> selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                    return (item);
            }
            return null;
        }

        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            MyFunc<Item, bool> selector = (Item item) => { return item.ItemType == ItemType.Weapon; };
            // Lambda 식 (일회용 함수)
            Item item = FindItem(selector);
            Console.WriteLine();
        }
    }
}