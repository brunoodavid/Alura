namespace _04_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;

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