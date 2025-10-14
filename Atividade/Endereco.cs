using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Endereco
    {
        private string? Street { get; set; }
        private int Number { get; set; }
        public string Neighborhood { get; set; } = String.Empty; //classe string empty
        public string ZipCode { get; set; }
        public string? Complement { get; set; } //? = nullable
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; } = string.Empty; // tipo primitivo string empty

        public Endereco(string street, int number, string neighborhood, 
            string zipcode, string? complement, string city, 
            string state, string country)
        {
            this.Street = street;
            this.Number = number;
            this.Neighborhood = neighborhood;
            this.ZipCode = zipcode;
            this.Complement = complement;
            this.City = city;
            this.State = state;
            this.Country = country;
        }
        public void showInfo()
        {
            Console.WriteLine($"Endereço: {Street}, {Number}");
            Console.WriteLine($"Bairro: {Neighborhood}");
            Console.WriteLine($"CEP: {ZipCode}");
            if (Complement != null)
            {
                Console.WriteLine($"Complemento: {Complement}");
            }
            Console.WriteLine($"Cidade {City}");
            Console.WriteLine($"Estado: {State}");
            Console.WriteLine($"País: {Country}");
        }
    }
}
