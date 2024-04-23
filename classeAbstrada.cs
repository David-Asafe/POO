public abstract class Rank{
    private string Nome;
    private int Poder;
    private int Vida;
    private int nivel;

    public Rank(string nome, int poder, int vida){
        this.Nome = nome;
        this.Poder = poder;
        this.Vida = vida;
    }
   public string GetNome(){
        return nome;
    }
    public void SetNome(string nome){
        this.Nome = nome;
    }
    public int GetPoder(){
        return poder;
    }
    public void SetPoder(string poder){
        this.Poder = poder;
    }
   public int GetVida(){
        return vida;
    }
    public void SetVida(string nivel){
        this.Vida = vida;
    }
    public int GetNivel(){
        return nivel;
    }
    public void SetNivel(string nivel){
        this.Nivel = nivel;
    }

    public abstract void Atacar(){
        Console.WriteLine($"{(GetNome)} atacou {GetNome()} e usou {GetPoder} de poder}.");
    }
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
        Console.WriteLine($"{GetNome} MORREU!");
    }
}

public class Classe_C : Rank {
    public Classe_C(string nome, int poder, int vida, int nivel) : base(string nome, int poder, int vida, int nivel){}
    public override void Atacar(){
        Console.WriteLine($"{GetNome}ataca com seu poder mediano!");
    }
}
public class Classe_B : Rank {
    public Classe_B(string nome, int poder, int vida, int nivel) : base(string nome, int poder, int vida, int nivel){}
    public override void Atacar(){
        Console.WriteLine($"{GetNome}ataca com seu poder mais fraco!");
    }
}
public class Classe_A : Rank {
    public Classe_A(string nome, int poder, int vida, int nivel) : base(string nome, int poder, int vida, int nivel){}
    public override void Atacar(){
        Console.WriteLine($"{GetNome}ataca com seu soco(sem arma)!");
    }
}
public class Classe_S : Rank {
    public Classe_S(string nome, int poder, int vida, int nivel) : base(string nome, int poder, int vida, int nivel){}
    public override void Atacar(){
        Console.WriteLine($"{GetNome}ataca com sua andada(forte dms)!!");
    }
}


