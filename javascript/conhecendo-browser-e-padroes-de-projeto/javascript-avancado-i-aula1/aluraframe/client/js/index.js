var inputData = document.querySelector("#data");
var inputQuantidade = document.querySelector("#quantidade");
var inputValor = document.querySelector("#valor");
var form = document.querySelector(".form");


form.addEventListener('submit', function (event) {
    event.preventDefault();

    var tr = document.createElement('tr');
    var tdData = document.createElement('td');
    var tdQuantidade = document.createElement('td')
    var tdValor = document.createElement('td')
    var tdVolume = document.createElement('td')

    tdData.textContent = inputData.value;
    tdQuantidade.textContent = inputQuantidade.value;
    tdValor.textContent = inputValor.value;
    tdVolume.textContent = tdQuantidade.textContent * tdValor.textContent;
    
    tr.appendChild(tdData);
    tr.appendChild(tdQuantidade);
    tr.appendChild(tdValor);
    tr.appendChild(tdVolume);

    var tabela = document.querySelector("table tbody");
    tabela.appendChild(tr);

    inputData.value = "";
    inputQuantidade.value = 1;
    inputValor.value = 0,0;

    inputData.focus();
})

