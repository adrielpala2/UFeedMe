document.querySelectorAll(".card-link").forEach(link => {
    link.addEventListener("click", (event) => {
        const divSelecionada = event.currentTarget.querySelector(".card").id;
        localStorage.setItem("card", divSelecionada);
        console.log(`Card Selecionado: ${divSelecionada}`);
    });
});

document.querySelectorAll(".emotion").forEach(link => {
    link.addEventListener("click", (event) => {
        const satisfacaoSelecionada = event.currentTarget.id;
        localStorage.setItem("emotion", satisfacaoSelecionada);
        console.log(`Nível de Satisfação Selecionado: ${satisfacaoSelecionada}`);
    });
});

document.querySelectorAll(".emotion").forEach(link => {
    link.addEventListener("click", (event) => {
        const satisfacaoSelecionada = event.currentTarget.id;
        localStorage.setItem("emotion", satisfacaoSelecionada);
        console.log(`Nível de Satisfação Selecionado: ${satisfacaoSelecionada}`);
    });
});

document.getElementById("email").addEventListener("input", (event) => {
    localStorage.setItem("emailUsuario", event.target.value);
});

document.getElementById("sugestao").addEventListener("input", (event) => {
    localStorage.setItem("sugestaoUsuario", event.target.value);
});


