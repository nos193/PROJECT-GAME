using System;

namespace Project_CS
{
    public class Person
    {
        private int _accuracy;
        private string _name;
        private int _health;
        private int _attack;
        private int _mana;        

        public int Accuracy
        {
            get { return _accuracy; }
            set { _accuracy = value; }
        }
        public string Name
        {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }
        public int Health
        {
            get {
                return _health;
            }
            set {
                _health = value;
            }
        }
        public int Attack
        {
            get {
                return _attack;
            }
            set {
                _attack = value;
            }
        }
        public int Mana
        {
            get {
                return _mana;
            }
            set {
                _mana = value;
            }
        }
        public void Hero()
        {
            Name = "";
            Accuracy = 0;
            Health = 0;
            Attack = 0;
            Mana = 0;
        }
    }
}

        /*
        public Person(string name, int health, int attack, int mana)
        {
            _name = name;
            _health = health;
            _attack = attack;
            _mana = mana;
        }
        */