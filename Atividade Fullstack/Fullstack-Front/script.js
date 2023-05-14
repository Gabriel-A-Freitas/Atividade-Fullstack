fetch('https://localhost:7096/Tarefas')
  .then(response => response.json())
  .then(data => console.log(data))
  .then(data => {
    const tarefas = data;
    // Iterar sobre a lista de tarefas e exibi-las no front-end
    tarefas.forEach(tarefa => {
      $(document).ready(function () {
        carregarTarefas();
      });
    });
  })
  .catch(error => console.error(error));

