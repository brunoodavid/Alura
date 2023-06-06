namespace ExercicioSomandoPares{
    class Program{
        static void Main(string[] args){
            SomarNumeros(new int[] {1,2,3,4,5});
        }

        static void SomarNumeros(int[] numeros){
            for(int i = 0; i < numeros.Length - 1; i+=2){
                int primeiroNumero = numeros[i];
                int segundoNumero = numeros[i+1];

                int soma = primeiroNumero + segundoNumero;

                Console.WriteLine($"{primeiroNumero} + {segundoNumero} = {soma}");
            }
        }
    }
}