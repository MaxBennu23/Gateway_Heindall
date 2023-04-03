// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $("#botao-filtrar").click(function () {
        var filtro = $("#filtro-id-agencia").val().toUpperCase();
        $("#tabela-rotas tbody tr").each(function () {
            var idAgencia = $(this).find("td[data-grupo]").text().toUpperCase();
            if (idAgencia.indexOf(filtro) > -1) {
                $(this).show();
            } else {
                $(this).hide();
            }
        });
    });
});

$(document).ready(function () {
    $("#botao-filtrar-grupos").click(function () {
        var input, filter, table, tr, td, i, txtValue;
        input = document.getElementById("tabela-grupos");
        filter = input.value.toUpperCase();
        table = document.getElementById("tabela-grupos");
        tr = table.getElementsByTagName("tr");
        for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName("td")[0];
            if (td) {
                txtValue = td.textContent || td.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = "";
                } else {
                    tr[i].style.display = "none";
                }
            }
        }
    });
});


const text = "Conectando as melhores oportunidades.";
let index = 0;

function typeEffect() {
    document.querySelector('#texto-digitado').textContent += text[index];
    index++;

    if (index === text.length) {
        clearInterval(timer);
    }
}

const timer = setInterval(typeEffect, 100);

typeEffect(); // chama a função para iniciar o efeito de digitação


/*

const texterro = "EM DESENVOLVIMENTO";
let index = 0;

function typeEffect() {
    document.querySelector('#texto-erro').textContent += texterro[index];
    index++;

    if (index === text.length) {
        clearInterval(timer);
    }
}

const timer = setInterval(typeEffect, 100);

typeEffect(); // chama a função para iniciar o efeito de digitação


 HELP : Filtro : Este JS executa filtro na View Conexoes

 Nesse exemplo, a entrada do usuário é convertida para maiúsculas usando toUpperCase()
 para que a pesquisa seja insensível a maiúsculas e minúsculas. O método indexOf() é 
 usado para verificar se a entrada do usuário corresponde ao conteúdo da coluna GRUPO 
 em cada linha. Se a linha corresponder, ela é exibida com o método show(). 
 Caso contrário, ela é ocultada com o método hide().

Precisa ter a biblioteca jQuery carregada na sua View. 
*/
