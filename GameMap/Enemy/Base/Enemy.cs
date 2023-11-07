using GameMap.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMap
{
    public class Enemy : aCharacter
    {
        public string EnemyName { get; set; }

        public eEnemyType EnemyType;

        public Enemy() {

            Console.WriteLine("Düsman Olusturuldu");
            LoadSkills();
            CharacterType = eCharacterType.E;


        }

        public override void LoadSkills()
        {
            var poison = new Poison()
            {
                PoisonType = ePoisonType.Slowness,
                PoisonLevel = 1,
                SkillName = "Zehirsalan",
                Damage = 24,
                Duration = 30,
                SkillType = eSkillType.NotAreaDAmage,
            };
            this.Skills.Add(poison);

        }

        public override void LoadInventory()
        {
            throw new NotImplementedException();
        }
    }
}
