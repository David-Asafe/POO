using System;
interface IAtaque {
    void Atacar();
}

public abstract class Heroi{
    private string nome;
    private int forca;
    private int vida;
    private int stamina;

    public class Heroi(string nome, int forca, int vida, int stamina){
        this.nome = nome;
        this.forca = forca;
        this.vida = vida;
        this.stamina = stamina;
    }
    public string GetNome(){
        return nome;
    }
    public void SetNome(string nome){
        this.nome = nome;
    }
    public int GetForca(){
        return forca;
    }
    public void Setforca(int forca){
        this.forca = forca;
    }
    public int GetVida(){
        return vida;
    }
    public void SetVida(int vida){
        this.vida = vida;
    }
    public int GetStamina(){
        return stamina;
    }
    public void SetStamina(int stamina){
        this.stamina = stamina;
}

    public abstract Especial();
}

public class Estudante : IAtaque, Heroi {
    public Estudante(string nome, int forca, int vida, int stamina) : base(nome, forca, vida, stamina){}
    public void Atacar(int dano){
        forca += dano;
        if (forca >= 200){
            Matar();
        }
        else{
            Console.WriteLine($"{GetNome()} atacou e causou {dano} de dano.");
        }
    }
}

public class Professor : IAtaque, Heroi {
    public Professor(string nome, int forca, int vida, int stamina) : base(nome, forca, vida, stamina){}
    public void Atacar(int dano){
        forca += dano;
        if (forca >= 200){
            Matar();
        }
        else{
            Console.WriteLine($"{GetNome()} atacou e causou {dano} de dano.");
        }
    }
}
public class Coordenador : IAtaque, Heroi {
    public Coordenador(string nome, int forca, int vida, int stamina) : base(nome, forca, vida, stamina){}
    public void Atacar(int dano){
        forca += dano;
        if (forca >= 200){
            Matar();
        }
        else{
            Console.WriteLine($"{GetNome()} atacou e causou {dano} de dano.");
        }
    }
}

class Program {
    static void Main(string[] args) {
        Estudante estudante = new estudante("Pires", 50, 100, 75);
        Professor professor = new professor("Julio", 60, 50, 10);
        Coordenador coordenador = new coordenador("Paulo", 100, 100, 100);

        estudante.Atacar(10);

        professor.Atacar(48);

        coordenador.Atacar(96);

        coordenador.Atacar(72);

        estudante.Atacar(46);

        professor.Atacar(69);
    }
}