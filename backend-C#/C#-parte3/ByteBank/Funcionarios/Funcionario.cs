namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set;}
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public string Senha { get; set; }

        public Funcionario(double salario, string cpf){
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public bool Autenticar(string senha){
            return Senha == senha;
        }
        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}