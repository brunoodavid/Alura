using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Tests;

public class PatioTeste
{
    private Operador operador;
    private Veiculo veiculo;
    public PatioTeste(){
        veiculo = new Veiculo();
        operador = new Operador();
        operador.Nome = "André Silva";
    }

    [Fact]
    public void ValidaFaturamento()
    {

        //Arrange
        var estacionamento = new Patio();
        estacionamento.OperadorPatio = operador;
        veiculo.Proprietario = "Bruno Hoffmann";
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Cor = "Preto";
        veiculo.Modelo = "Cronos";
        veiculo.Placa = "ASD-9999";

        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

        //Act
        double faturamento = estacionamento.TotalFaturado();

        //Assert
        Assert.Equal(2, faturamento);
    }

    [Theory]
    [InlineData("Andre Silva", "ASD-1498", "preto", "Gol")]
    [InlineData("Jose Silva", "POL-9242", "verde", "Fusca")]
    [InlineData("Maria Silva", "GDR-6524", "vermelho", "Opala")]
    public void ValidaFaturamentoComVariosVeiculos(string proprietario,
                                                   string placa,
                                                   string cor,
                                                   string modelo)
    {
        //Arrange
        Patio estacionamento = new Patio();
        estacionamento.OperadorPatio = operador;
        veiculo.Proprietario = proprietario;
        veiculo.Placa = placa;
        veiculo.Cor = cor;
        veiculo.Modelo = modelo;

        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

        //Act
        double faturamento = estacionamento.TotalFaturado();

        //Assert
        Assert.Equal(2, faturamento);
    }

    [Theory]
    [InlineData("Maria Silva", "GDR-6524", "vermelho", "Opala")]
    public void LocalizaVeiculoNoPatio(string proprietario,
                                                   string placa,
                                                   string cor,
                                                   string modelo)
    {
        //Arrange
        Patio estacionamento = new Patio();
        estacionamento.OperadorPatio = operador;
        veiculo.Proprietario = proprietario;
        veiculo.Placa = placa;
        veiculo.Cor = cor;
        veiculo.Modelo = modelo;

        estacionamento.RegistrarEntradaVeiculo(veiculo);

        //Act 
        var consultado = estacionamento.PesquisaVeiculo(veiculo.IdTicket);

        //Assert
        Assert.Contains("### Ticket Estacionamento Alura ###", consultado.Ticket);
    }

    [Fact]
    public void AlterarDadosVeiculos()
    {
        //Arrange
        Patio estacionamento = new Patio();
        estacionamento.OperadorPatio = operador;
        veiculo.Proprietario = "José Silva";
        veiculo.Placa = "ZXC-8524";
        veiculo.Cor = "Verde";
        veiculo.Modelo = "Opala";
        estacionamento.RegistrarEntradaVeiculo(veiculo);

        var veiculoAlterado = new Veiculo();
        veiculoAlterado.Proprietario = "José Silva";
        veiculoAlterado.Placa = "ZXC-8524";
        veiculoAlterado.Cor = "Preto"; //Alterado
        veiculo.Modelo = "Opala";

        //Act
        Veiculo alterado = estacionamento.AlterarDadosVeiculos(veiculoAlterado);

        //Assert
        Assert.Equal(alterado.Cor, veiculoAlterado.Cor);
    }
}