kuobe briamtepublic class Produto {
    private string nome;
    private decimal preco;
    private string descricao;
    private string categoria;

    public Produto (string nome, decimal preco, string descricao, string categoria){
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;
    }
    public string Nome{
        get {return nome;}
        set {nome = value;}
    }
    public decimal Preco{
        get {return preco;}
        set {preco = value;}
    }
    public string Descricao{
        get {return descricao;}
        set {descricao = value;}
    }
    public string Categoria{
        get {return categoria;}
        set {categoria = value;}
    }
}
public class ConsoleGame: Produto {
    private string capacidadeArmazanamento;

   
    public ConsoleGame(string nome, decimal preco, string descricao, string categoria, int capacidadeArmazanamento): base(nome, preco, descricao, categoria) {
        CapacidadeArmazanamento = capacidadeArmazanamento
    }
     public int capacidadeArmazanamento{
        get { return capacidadeArmazanamento ;}
        set { capacidadeArmazanamento = value;}
    }
}
public class Jogo: Produto {
    private string genero;

   
    public Jogo(string nome, decimal preco, string descricao, string categoria, string genero): base(nome, preco, descricao, categoria) {
        Genero = genero
    }
     public string Genero{
        get { return genero ;}
        set { genero = value;}
    }
}
public class Acessorio: Produto {
    private string Tipo;

   
    public Acessorio(string nome, decimal preco, string descricao, string tipo): base(nome, preco, descricao, categoria, tipo) {
        Tipo = tipo
    }
     public string Tipo{
        get { return Tipo ;}
        set { tipo = value;}
    }
}
public class Colecionavel: Produto {
    private bool EdicaoLimitada;

   
    public EdicaoLimitada(string nome, decimal preco, string descricao, string EdicaoLimitada): base(nome, preco, descricao, categoria, edicaoLimitada) {
        EdicaoLimitada = edicaoLimitada
    }
     public int EdicaoLimitada{
        get { return EdicaoLimitada;}
        set { edicaoLimitada = value;}
    }
}
    
public class Program {
    public static void main (string[] args) {
        Produto produto;
        produto = new ConsoleGame("PC Gamer", 2.200, "I9 de décima primeira geração, RTX 4090 de 16GB, 64GB RAM, PLACA MAE GIGABYTE Z790 AORUS XTREME, DDR5", "Computador" 65536);

        Jogo jogo = new Jogo("NBA 2K24 Black Mamba Edition", 499,00, "Melhor experiencia dos jogos da NBA", "Jogo");

        Acessorio acessorio = new Acessorio("Samsung Smart Tv 85 Neo Qled 8k, 292 polegadas", 1.000, "Mini Led | Painel 120hz | Processador com IA | 85", "Periféricos");

        Colecionavel colecionavel = new Colecionavel("Controle Ps4 com Grip Modern Warfare Limited Gold Stelf", 100,00, "CUSTOMIZAÇÃO STELF NO CONTROLE PS4 ORIGINAL", "Modern Warfare Limited", true);
        
    }
}
