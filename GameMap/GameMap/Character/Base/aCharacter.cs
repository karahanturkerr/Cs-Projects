using GameMap.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GameMap
{
    public abstract class aCharacter
    {

        public int HP;

        public int Speed;

        public List<aSkill> Skills = new List<aSkill>();
        public List<aInventory> Inventories = new List<aInventory>();

        public eCharacterType CharacterType;

        public Point location { get; set; } = new Point();

        public abstract void LoadSkills();
        public abstract void LoadInventory();

    }
}

    