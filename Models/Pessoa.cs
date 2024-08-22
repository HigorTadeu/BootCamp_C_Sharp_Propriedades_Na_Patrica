using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCamp_C_Sharp_Propriedades_Na_Patrica.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;            
        }

        private string _nome;
        private int _idade;

        public string Nome 
        { 
            /*
                Pode também ser feito o mesmo return de maneira mais simplificada (Body Expressions), 
                sempre que possível com código tiver uma linha
                
                get => _nome.ToUpper();
            */
            get
            {
                return _nome.ToUpper();
            }

            set
            {   //Testa se o nome passado é vazio, caso seja retorna um Exception
                if (value == "") 
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome.ToUpper()}";

        public int Idade 
        { 
            get => _idade;
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero.");
                }

                _idade = value;
            }

        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}