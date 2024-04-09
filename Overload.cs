public class Personagem {
    private string Classe;
    private string Especial;
    private int stamina;

    public Personagem (string classe, string especial, int stamina, int stamina){
        this.Classe = classe;
        this.Especial = especial;
        this.Stamina = stamina;
    }
    public string Classe{
        get {return classe;}
        set {classe = value;}
    }
    public string Especial{
        get {return especial;}
        set {especial = value;}
    }
    public int Stamina{
        get {return stamina;}
        set {stamina = value;}
    }
    public virtual void Atacar() {
        Console.WriteLine("Ataque básico!")
    }
}
public class Soldado: Personagem {
    private string TiroBasico;

   
    public Soldado(string classe, int stamina, string especial, string tiroBasico): base(classe, especial, stamina, tiroBasico) {
        TiroBasico = tiroBasico
    }
     public int TiroBasico{
        get { return TiroBasico ;}
        set { tiroBasico = value;}
    }

    public void Atacar(string habilidade) {
        Console.WriteLine("Bazuca" + habilidade)
    }

}
public class Sniper: Personagem {
    private string pistolaSilenciada;

   
    public Sniper(string classe, int stamina, string especial, string pistolaSilenciada): base(classe, especial, stamina, pistolaSilenciada) {
        pistolaSilenciada = pistolaSilenciada
    }
     public string pistolaSilenciada{
        get { return pistolaSilenciada ;}
        set { pistolaSilenciada = value;}
    }

       public void Atacar(string habilidade) {
        Console.WriteLine("Bala especial" + habilidade)
    }
   
}
public class Medico: Personagem {
    private string Medico;

   
    public Medico(string classe, int stamina, string especial, string medico): base(classe, especial, stamina, especial, medico) {
        Medico = medico
    }
     public string Medico{
        get { return medico ;}
        set { medico = value;}
    }

    public void Atacar(string habilidade) {
        Console.WriteLine("Parasita" + habilidade)
    }

}
    
public class Program {
    public static void main (string[] args) {
        Personagem personagem;
        Soldado soldado = new Soldado("Militar", 90, "Adrenalina", "Tiro de M4");
        Soldado.Atacar();
        Soldado.Atacar("Rajada de Tiro");

        Sniper sniper = new Sniper("Militar", 65, "Tiro extremamente preciso", "Usp");
        Sniper.Atacar();
        Sniper.Atacar("Estabilidade extra");

        Medico medico = new Medico("Militar", 80, "Cura rápida", "Ajudar");
        Medico.Atacar();
        Medico.Atacar("Cura mais de um");
        
    }
}
