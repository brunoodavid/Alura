namespace _02_ByteBank
{
    public class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        public bool sacar(double valor){
            if(this.saldo < valor){
                return false;
            } else {
                this.saldo -= valor;
                return true;
            }
        }

        public void depositar(double valor){
            this.saldo = this.saldo + valor;
        }

        public bool transferir(double valor, ContaCorrente contaDestino){
            if(this.saldo < valor){
                return false;
            } else {
                this.saldo -= valor;
                contaDestino.depositar(valor);
                return true;
            }
        }
    }
}