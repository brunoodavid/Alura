var paciente = document.querySelectorAll(".paciente");

var tabela = document.querySelector("#tabela-pacientes");

tabela.addEventListener("dblclick", function(event){
    var alvoEvento = event.target;
    var paiDoAlvo = alvoEvento.parentNode;
    paiDoAlvo.classList.add("fadeOut");
    setTimeout(function(){
        paiDoAlvo.remove();
    }, 500);
    
});

// paciente.forEach(function(pacientes){
//     pacientes.addEventListener("dblclick", function(){
//         this.remove();
//     });
// })