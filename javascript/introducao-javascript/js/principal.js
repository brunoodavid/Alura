var titulo = document.querySelector(".titulo");
titulo.textContent = "Aparecida Nutricionista";

var pacientes = document.querySelectorAll(".paciente")

for (var i = 0; i < pacientes.length; i++) {


    var tdPeso = pacientes[i].querySelector(".info-peso")
    var tdAltura = pacientes[i].querySelector(".info-altura")
    var peso = tdPeso.textContent
    var altura = tdAltura.textContent
    var tdImc = pacientes[i].querySelector(".info-imc")
    var pesoEhValido = true;
    var alturaEhValida = true;

    if (peso <= 0 || peso >= 500) {
        pesoEhValido = false;
        tdImc.textContent = "Peso inválido"
        pacientes[i].classList.add("paciente-invalido")
    }

    if (altura <= 0 || altura >= 3) {
        alturaEhValida = false;
        tdImc.textContent = "Altura inválida"
        pacientes[i].classList.add("paciente-invalido")
    }

    if (pesoEhValido && alturaEhValida) {
        var imc = peso / (altura * altura)
        tdImc.textContent = imc.toFixed(2)
    }
}
