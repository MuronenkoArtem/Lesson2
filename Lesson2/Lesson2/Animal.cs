using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Animal
    {
        public KindAnim KindAnim { get; protected set; }
        public string Name { get; protected set; }
        public int health { get; set; }
        public StateAnim State { get; set; }
        public int MaxHp = 0;
    }
    public enum KindAnim
    {
        Lion,
        Tiger,
        Elefant,
        Bear,
        Wolf,
        Fox
    }
    public enum StateAnim
    {
        Full,
        Hungry,
        Ill,
        Dead
    }
    public class Lion : Animal
    {
        public Lion(string name)
        {
            KindAnim = KindAnim.Lion;
            Name = name;
            health = 5;
            State = StateAnim.Full;
            MaxHp = 5;
        }
    }
    public class Tiger : Animal
    {
        public Tiger(string name)
        {
            KindAnim = KindAnim.Tiger;
            Name = name;
            health = 4;
            State = StateAnim.Full;
            MaxHp = 4;
        }
    }
    public class Elefant : Animal
    {
        public Elefant(string name)
        {
            KindAnim = KindAnim.Elefant;
            Name = name;
            health = 7;
            State = StateAnim.Full;
            MaxHp = 7;
        }
    }
    public class Bear : Animal
    {
        public Bear(string name)
        {
            KindAnim = KindAnim.Bear;
            Name = name;
            health = 6;
            State = StateAnim.Full;
            MaxHp = 6;
        }
    }
    public class Wolf : Animal
    {
        public Wolf(string name)
        {
            KindAnim = KindAnim.Wolf;
            Name = name;
            health = 4;
            State = StateAnim.Full;
            MaxHp = 4;
        }
    }
    public class Fox : Animal
    {
        public Fox(string name)
        {
            KindAnim = KindAnim.Fox;
            Name = name;
            health = 3;
            State = StateAnim.Full;
            MaxHp = 3;
        }
    }
}
