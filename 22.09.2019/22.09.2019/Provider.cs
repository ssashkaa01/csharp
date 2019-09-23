using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._2019
{
    class Provider
    {
        // private fields
        private string name;
        private string country;
        private short raiting;
        private bool isPayVAT;

        // public properties for getting and setting (get, set)
        public string Name
        {
            get
            {

                if (Char.IsLower(name[0]))
                {
                    return name.Substring(0, 1).ToUpper() + name.Remove(0, 1);
                }
                else
                {
                    return name;
                }
            }
            set
            {

                if (String.IsNullOrWhiteSpace(value))
                {
                    name = "No name";
                }
                else
                {
                    name = value;

                }
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    country = "No name";
                }
                else
                {
                    country = value;
                }
            }
        }
        public short Raiting
        {
            get { return raiting; }
            set
            {

                if (value > 0 && value < 6)
                {
                    raiting = value;

                }
                else
                {
                    raiting = 0;
                }
                IsPayVAT = (value > 2);
            }
        }
        public bool IsPayVAT
        {
            get { return isPayVAT; }
            private set { isPayVAT = value; }
        }

        // Constructor        
        public Provider(string name, string country)
        {
            this.name = name;
            this.country = country;
            raiting = (short)new Random().Next(6);  // randomize number from 0 to 5
            isPayVAT = (raiting > 2);   // if raiting more than 2, provider paying VAT
        }
        public void Show()
        {
            Console.WriteLine($"Name: {name}\n" +
                $"Country: {country}\n" +
                $"Raiting: {(raiting > 0 ? new string('*', raiting) : "No raiting")}\n" + // if there`s raiting, create string with ctor
                $"{(isPayVAT ? "Pay VAT" : "Not pay VAT")}\n");
        }
    }
}
