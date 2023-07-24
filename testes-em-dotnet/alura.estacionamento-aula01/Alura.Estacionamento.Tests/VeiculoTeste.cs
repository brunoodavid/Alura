using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Tests;

public class VeiculoTeste
{
    private Veiculo veiculo;

    public VeiculoTeste()
    {
        veiculo = new Veiculo();
    }
    [Fact]
    public void TestaVeiculoAcelerar()
    {
        //var veiculo = new Veiculo();
        veiculo.Acelerar(10);
        Assert.Equal(100, veiculo.VelocidadeAtual);
    }

    [Fact]
    public void TestaVeiculoFrear()
    {
        //var veiculo = new Veiculo();
        veiculo.Frear(10);
        Assert.Equal(-150, veiculo.VelocidadeAtual);
    }

    [Fact]
    public void TestaVeiculo()
    {
        var veiculo = new Veiculo();
        Assert.Equal(TipoVeiculo.Automovel, veiculo.Tipo);
    }

    [Fact(Skip = "Teste ainda não implementado, ignorar")]
    public void ValidaNomeProprietario()
    {

    }

    [Fact]
    public void DadosVeiculo()
    {
        //var veiculo = new Veiculo();
        veiculo.Proprietario = "Carlos Silva";
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Placa = "ZAP-1928";
        veiculo.Cor = "Verde";
        veiculo.Modelo = "Variante";

        //Act
        string dados = veiculo.ToString();

        //Assert
        Assert.Contains("Ficha do veiculo:", dados);
    }

    [Fact]
    public void TestaNomeProprietarioVeiculoComMenosDeTresCaracteres()
    {
        string nomeProprietario = "Ab";

        Assert.Throws<FormatException>(
            () => new Veiculo(nomeProprietario)
        );
    }

    public void TestaMensagemDeExcecaoDoQuartoCaractereDaPlaca()
    {
        string placa = "ASDF8888";

        var mensagem = Assert.Throws<FormatException>(
            () => new Veiculo().Placa = placa
        );

        Assert.Equal("O 4° caractere deve ser um hífen", mensagem.Message);
    }

    [Fact]
    public void TestaMensagemDeExcecaoDosUltimosCaracteresDaPlaca(){
        string placa = "ASD-FFFF";

        var mensagem = Assert.Throws<FormatException>(
            () => new Veiculo().Placa = placa
        );

        Assert.Equal("Do 5º ao 8º caractere deve-se ter um número!", mensagem.Message);
    }

}