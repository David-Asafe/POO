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
 public class Funcionario : Pessoa{
    privatedouble salario;
    
    //Método para calcular o bônus
    public double Bonus(){
        return salario * 0.1;// 10% de bônus padrão sobre o salario
    }

    //Construtor da classe Estudante
    public Funcionario(string nome, int idade, string cpf, double salario) : base(nome, idade, cpf) {
        salario = salario;
    }

    //Propriedades da classe Estudante que opermite acesso controla a um campo privado
    public string Salario {
        get {return salario; }
        set { salario = value; }
    }
}
public class Diretor : Funcionario { 
    
    //Contrutor da classe Gerente
    public Diretor(string nome, int idade, string cpf, double salario) : base(nome, idade, cpf, salario){
        //
    }

    //Sobrescrevendo o método Bonus para adicionar 1000 ao bônus
    public override double Bonus {
        return base.Bonus() + 1000: //Bônus padrão do funcionario de 10% sobre o salário + 1000
    }
}