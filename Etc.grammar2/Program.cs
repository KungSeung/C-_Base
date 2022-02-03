using System;
using System.Collections.Generic;

namespace Etc.grammar2
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

		
		delegate Return MyFunc<Return>();
		delegate Return MyFunc<T, Return>(T item);
		delegate Return MyFunc<T1, T2, Return>(T1 t1, T2 t2);

		/*static bool IsWeapon(Item item)
		{
			return item.ItemType == ItemType.Weapon;
		}*/

		static Item FindItem(Func<Item, bool> selector)
		{
			foreach(Item item in _items)
			{
				if (selector(item))
					return item;
			}
			return null;
		}

		/*static void Main(string[] args)
		{
			_items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
			_items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
			_items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

			MyFunc<Item, bool> selector = new MyFunc<Item, bool>((Item item) => { return item.ItemType == ItemType.Weapon; });
			MyFunc<Item, bool> selector2 = (Item item) => { return item.ItemType == ItemType.Weapon; };             // 이런식으로 줄일 수 있음

			// delegate를 직접 선언하지 않아도, 이미 만들어진 애들이 존재
			// -> 반환 타입이 있을 경우 Func
			// -> 반환 타입이 없으면 Action
			Func<Item, bool> selector3 = (Item item) => { return item.ItemType == ItemType.Weapon; };

			// Lambda : 일회용 함수를 만드는데 사용하는 문법이다, 함수 선언없이 빠르게 만들 수 있음
			// 한번 쓰고 버리는 용도

			// delegate 사용(Anonymous Function) - 무명함수 / 익명함수 라고 한다, Lambda식이 아님
			Item item = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; });
			// 아래는 Lambda식에 해당
			Item item2 = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });             // 이런식으로 줄일 수 있음
		}*/
	}
}
