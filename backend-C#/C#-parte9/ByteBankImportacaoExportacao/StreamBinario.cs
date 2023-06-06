using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void EscritaBinaria(){
            using (var fs = new FileStream("ContaCorrente.txt", FileMode.Create)){
                using (var escritor = new BinaryWriter(fs)){
                    escritor.Write(456);
                    escritor.Write(45453534);
                    escritor.Write(4000.50);
                    escritor.Write("Gustavo Braga");
                }
            }
        }

        static void LeituraBinaria(){
            using (var fs = new FileStream("ContaCorrente.txt", FileMode.Open)){
                using (var leitor = new BinaryReader(fs)){
                    var agencia = leitor.ReadInt32();
                    var numeroConta = leitor.ReadInt32();
                    var saldo = leitor.ReadDouble();
                    var titular = leitor.ReadString();

                    Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
                }
            }
        }
    }
}