using System;
public abstract class Rank{
    private string nome;
    private int poder;
    private int vida;
    private int nivel;

    public Rank(string nome, int poder, int vida, int nivel){
        this.nome = nome;
        this.poder = poder;
        this.vida = vida;
        this.nivel = nivel;
    }
   public string GetNome(){
        return nome;
    }
    public void SetNome(string nome){
        this.nome = nome;
    }
    public int GetPoder(){
        return poder;
    }
    public void SetPoder(int poder){
        this.poder = poder;
    }
   public int GetVida(){
        return vida;
    }
    public void SetVida(int nivel){
        this.vida = vida;
    }
    public int GetNivel(){
        return nivel;
    }
    public void SetNivel(int nivel){
        this.nivel = nivel;
    }

    public abstract void Atacar();
    public abstract void Defender();

     public void ReceberDano(int dano){
        vida -= dano;
        if (vida <= 0){
            Morrer();
        }
        else{
            Console.WriteLine($"{GetNome()} recebeu {dano} de dano. Vida restante: {GetVida()}");
        }
    }
    public void Morrer(){
        Console.WriteLine($"{GetNome()} MORREU!");
    }
}

public class Classe_C : Rank {
    public Classe_C(string nome, int poder, int vida, int nivel) : base(nome, poder, vida, nivel){}
    public override void Atacar(){
        Console.WriteLine($"{GetNome()} ataca com seu poder mediano!");
    }
    public override void Defender(){
        Console.WriteLine($"{GetNome()} defendeu um ataque!");
    }
}
public class Classe_B : Rank {
    public Classe_B(string nome, int poder, int vida, int nivel) : base(nome, poder, vida, nivel){}
    public override void Atacar(){
        Console.WriteLine($"{GetNome()} ataca com seu poder mais forte!");
    }
     public override void Defender(){
        Console.WriteLine($"{GetNome()} defendeu um ataque!");
    }
}
public class Classe_A : Rank {
    public Classe_A(string nome, int poder, int vida, int nivel) : base(nome, poder, vida, nivel){}
    public override void Atacar(){
        Console.WriteLine($"{GetNome()} socou!");
    }
     public override void Defender(){
        Console.WriteLine($"{GetNome()} defendeu um ataque!");
    }
}
public class Classe_S : Rank {
    public Classe_S(string nome, int poder, int vida, int nivel) : base(nome, poder, vida, nivel){}
    public override void Atacar(){
        Console.WriteLine($"{GetNome()} piscou!!");
    }
     public override void Defender(){
        Console.WriteLine($"{GetNome()} nao sofreu dano!");
    }
}
class Program {
    static void Main(string[] args) {
        Classe_A classe_A = new Classe_A("Samuel", 765, 75, 650 );
        Classe_B classe_B = new Classe_B("Eduardo", 650, 70, 625);
        Classe_C classe_C = new Classe_C("Juan", 400, 50, 550);
        Classe_S classe_S = new Classe_S("Gabriel", 2500, 150, 1352);

        classe_A.Atacar();

        classe_B.ReceberDano(400);

        classe_C.Defender();

        classe_S.Defender();

        classe_B.Atacar();

        classe_A.ReceberDano(200);

        classe_C.Morrer();

        classe_A.Defender();

        classe_S.ReceberDano(5);

        classe_A.Atacar();

        classe_S.ReceberDano(10);

        classe_S.Atacar();

        classe_B.Morrer();
        
        classe_A.Morrer();
    }
}

