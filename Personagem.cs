    using System;

    public class Personagem {
        //Atributos
        private string nome;
        private string cor;
        private int idade;
        private double altura;
        private char genero;

        //Construtor
        public Personagem (string nome, string cor, int idade, double altura, char genero) {
            this.nome = nome;
            this.cor = cor;
            this.idade = idade;
            this.altura = altura;
            this.genero = genero
        }
        //Métodos
        public void ingoPersonagem() {
            console.WriteLine($"Nome: {nome}, idade: {idade}, altura: {altura}, genero: {genero}");
        }
        public void correr() {
            Console.WriteLine("Correndo.");
        }
        public void pular() {
            Console.WriteLine("Pulando.");
        }
    }
    public class Mario : Personagem {

        public Mario() {
            this.nome = "Mario";
            this.cor = "Vermelho"
            this.idade = 52;
            this.altura = 1.56;
            this.genero = "M";
        
            public void Estrela() {
                Console.WriteLine("Mario está invulnerável.");
            }
        }
    }
    public class Luigi : Personagem {

        public Luigi() {
                this.nome = "Luigi";
                this.cor = "Verde"
                this.idade = 47;
                this.altura = 1.61;
                this.genero = "M";
            
                public void FLor() {
                    Console.WriteLine("Mario usando a Flor.");
            }
        }
    }

    class Program {
        static void Main(dstring[] args) {
            Mario mario = new Mario();
            Luigi luigi = new Luigi();

            Console.WriteLine($"Nome:{Mario.Nome}, Cor{Mario.Cor}, Idade: {Mario.Idade}, Altura; {Mario.Altura}, Gênero: {Mario.Genero}");
            
            mario.correr();
            mario.pular();
            mario.estrela();

            Console.WriteLine();
            Console.WriteLine($"Nome:{luigi.Nome}, Cor{luigi.Cor}, Idade: {luigi.Idade}, Altura; {luigi.Altura}, Gênero: {luigi.Genero}");

            luigi.correr();
            luigi.pular();
            luigi.flor();
        }
    }