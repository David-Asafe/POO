 public class Pessoa {
    private string nome;
    private int idade;
    private string cpf;
    //Construtor da classe Pessoa
    public Pessoa(string nome, int idade, string cpf) {
        Nome = nome;
        Idade = idade;
        CPF = cpf;
    }
    //Propriedades da classe Pessoa que permite acesso controlado a um campo privado
    public string Nome {
        get {return nome;}
        set { nome = value;}
    }
    public int Idade{
        get {return idade;}
        set {idade = value;}
    }
    public string CPF{
        get {return cpf;}
        set {cpf = value;}
    }
 }
 public classEstudante: Pessoa {
    private String curso;

    //construtor da classe Estudante
    public Estudante(string nome, int idade, string cpf, string curso): base(nome, idade, cpf) {
        Curso = curso
    }

    //Propriedade da classe estudante que permite acessp controlado a um campo privado
    public String Curso{
        get { return curso;}
        get { Curso = value;}
    }
 }
