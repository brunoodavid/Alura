namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas{ get; private set;}
        private int _agencia;
        public int Agencia { 
            get{
                return _agencia;
            } 
            set{
                if(value <= 0){
                    return;
                }
                _agencia = value;
            }
        }
        public int Numero { get; set; }
        private double _saldo = 100;

        public ContaCorrente(int agencia, int numero){
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
        }

        public double Saldo{
            get{
                return _saldo;
            }
            set{
                if(value < 0){
                    return;
                }
                _saldo = value;
            }
        }

        public bool sacar(double valor){
            if(this._saldo < valor){
                return false;
            } else {
                this._saldo -= valor;
                return true;
            }
        }

        public void depositar(double valor){
            this._saldo = this._saldo + valor;
        }

        public bool transferir(double valor, ContaCorrente contaDestino){
            if(this._saldo < valor){
                return false;
            } else {
                this._saldo -= valor;
                contaDestino.depositar(valor);
                return true;
            }
        }
    }
}