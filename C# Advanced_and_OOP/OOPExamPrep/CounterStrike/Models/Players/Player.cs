﻿using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Text;

namespace CounterStrike.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string username;
        private int health;
        private int armor;
        //private bool isAlive;
        private Gun gun;


        protected Player(string username, int health, int armor, IGun gun)
        {
            this.Username = username;
            this.Health = health;
            this.Armor = armor;
            this.Gun = gun;
        }


        public string Username
        {
            get => this.username;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerName);
                }

                this.username = value;
            }

        }

        public int Health
        {
            get => this.health;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerHealth);
                }

                this.health = value;
            }
        }

        public int Armor
        {
            get => this.armor;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerArmor);
                }

                this.armor = value;
            }
        }

        public IGun Gun
        {
            get => this.gun;

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGun);
                }

                this.gun = (Gun)value;
            }
        }

        public bool IsAlive
            => this.Health > 0;
        //{
        //    get => this.isAlive;

        //    protected set
        //    {
        //        if (this.Health <= 0)
        //        {
        //            this.isAlive = false;
        //        }
        //        this.isAlive = true;
        //    }
        //}

        public void TakeDamage(int points)
        {
            //if (!this.IsAlive)
            //{
            //    return;
            //}

            if (this.Armor >= points)
            {
                this.Armor -= points;
                return;
            }
            else
            {
                points -= this.Armor;
                this.Armor = 0;
            }

            if (this.Health >= points)
            {
                this.Health -= points;
                return;
            }
            else
            {
                this.Health = 0;
            }


            //if (this.Armor > 0)
            //{
            //    this.Armor -= points;

            //    if (this.Armor < 0)
            //    {
            //        int leftoverPoints = this.Armor * -1;
            //        this.Armor = 0;
            //        this.Health -= leftoverPoints;
            //    }
            //}
            //else
            //{
            //    this.Health -= points;
            //}

        }

        public override string ToString()
        {
            //return $"{this.GetType()}: {this.Username}" +
            //       $"{Environment.NewLine}--Health: {this.Health}" +
            //       $"{Environment.NewLine}--Armor: {this.Armor}" +
            //       $"{Environment.NewLine}--Gun: {this.Gun.Name}";

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}: {this.Username}");
            sb.AppendLine($"--Health: {this.Health}");
            sb.AppendLine($"--Armor: {this.Armor}");
            sb.AppendLine($"--Gun: {this.Gun.Name}");

            return sb.ToString().TrimEnd();
        }
    }
}
