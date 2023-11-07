using GameMap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMap
{
    public class Human : aCharacter
    {

        public string HumanName;
        public eHumanGender HumanGender;
        public Human()
        {
            Console.WriteLine("insan olusturuldu");
            LoadSkills();
            LoadInventory();
            CharacterType = eCharacterType.CS;

        }

        public override void LoadSkills()
        {
            var fire = new Fire()
            {
                Damage = 100,
                Duration = 100,
                FireTime = 100,
                SkillType = eSkillType.NotAreaDAmage
            };
            this.Skills.Add(fire);
        }

        public override void LoadInventory()
        {
            var weapon = new Weapon()
            {
                WeaponType = eWeaponType.sword,
                WeaponDamage = 100,
                WeaponHealth = 100,
                RawMaterialType = eRawMaterialType.Diamond,
                InventoryColorType = eColorType.White,
                Count = 1
            };
            this.Inventories.Add(weapon);

        }



    }
}
