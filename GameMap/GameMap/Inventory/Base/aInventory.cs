using GameMap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMap
{
    public abstract class aInventory
    {
        public eRawMaterialType RawMaterialType;

        public eColorType InventoryColorType;

        public int Count;

        public List<Weapon> Weapons = new List<Weapon>();
        public List<Armor> Armors = new List<Armor>();
        public List<Potion> Potions = new List<Potion>();
    }
}
