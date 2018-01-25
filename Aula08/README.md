<h1>Aula08</h1>
<h2>Realiza uma busca simples no banco de dados</h2>

    public ActionResult Index(string objetoNome)
     {
        var objetos = from m in db.Objetos select m;
        if (!String.IsNullOrEmpty(objetoNome))
        {
            objetos = objetoss.Where(s => s.Nome.Contains(nomeObjeto));
        }
        return View(objetos);
     }

    //L1 recebe o que será filtrado
    //L3 Recebe a tabela inteira e armazena na variavel
    //L4 Se o filtro estiver vazio entao irá mostrar todos os objetos
    //L6 Filtra a lista, buscando apenas objetos com o mesmo nome da pesquisa
