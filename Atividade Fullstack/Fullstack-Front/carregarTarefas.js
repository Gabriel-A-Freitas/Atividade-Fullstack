function carregarTarefas() {
  fetch('https://localhost:7096/Tarefas'), {
    method: "GET",
    mode: "cors",
    headers: {
      'Content-Type': 'application/json'
    }
  }
    .then(response => response.json())
    .then(data => {
      const lista = document.getElementById('lista-tarefas');
      data.forEach(tarefa => {
        const elemento = document.createElement('li');
        elemento.innerText = tarefa.Titulo;
        lista.appendChild(elemento);
      });
    })
    .catch(error => console.error('Erro ao carregar tarefas', error));
}



