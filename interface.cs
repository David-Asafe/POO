using System;

interface IAtaque {
    void Atacar(int dano);
}

public abstract class Heroi{
    private string nome;
    private int forca;
    private int vida;
    private int stamina;

    public Heroi(string nome, int forca, int vida, int stamina){
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
    public void SetForca(int forca){
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

    public abstract void Especial();
}

public class Estudante : IAtaque {
    private string nome;
    private int forca;
    private int vida;
    private int stamina;

    public Estudante(string nome, int forca, int vida, int stamina){
        this.nome = nome;
        this.forca = forca;
        this.vida = vida;
        this.stamina = stamina;
    }

    public void Atacar(int dano){
        forca += dano;
        if (forca >= 200){
            Matar();
        }
        else{
            Console.WriteLine($"{nome} atacou e causou {dano} de dano.");
        }
    }

    public void Especial(){
        // Implementação do método Especial para Estudante
    }

    private void Matar(){
        // Implementação do método Matar para Estudante
    }
}

public class Professor : IAtaque {
    private string nome;
    private int forca;
    private int vida;
    private int stamina;

    public Professor(string nome, int forca, int vida, int stamina){
        this.nome = nome;
        this.forca = forca;
        this.vida = vida;
        this.stamina = stamina;
    }

    public void Atacar(int dano){
        forca += dano;
        if (forca >= 200){
            Matar();
        }
        else{
            Console.WriteLine($"{nome} atacou e causou {dano} de dano.");
        }
    }

    public void Especial(){
        // Implementação do método Especial para Professor
    }

    private void Matar(){
        // Implementação do método Matar para Professor
    }
}

public class Coordenador : IAtaque {
    private string nome;
    private int forca;
    private int vida;
    private int stamina;

    public Coordenador(string nome, int forca, int vida, int stamina){
        this.nome = nome;
        this.forca = forca;
        this.vida = vida;
        this.stamina = stamina;
    }

    public void Atacar(int dano){
        forca += dano;
        if (forca >= 200){
            Matar();
        }
        else{
            Console.WriteLine($"{nome} atacou e causou {dano} de dano.");
        }
    }

    public void Especial(){
        // Implementação do método Especial para Coordenador
    }

    private void Matar(){
        // Implementação do método Matar para Coordenador
    }
}

class Program {
    static void Main(string[] args) {
        Estudante estudante = new Estudante("Pires", 50, 100, 75);
        Professor professor = new Professor("Julio", 60, 50, 10);
        Coordenador coordenador = new Coordenador("Paulo", 100, 100, 100);

        estudante.Atacar(10);

        professor.Atacar(48);

        coordenador.Atacar(96);

        coordenador.Atacar(72);

        estudante.Atacar(46);

        professor.Atacar(69);
    }
}