<h1>Aula08</h1>
<h2>Realiza uma busca simples no banco de dados</h2>
<p>Com uma string, busca no banco de dados com base a uma tabela e uma coluna, algum registro que possua os mesmos caracteres</p>

    public ActionResult Index(string objetoNome) //L1 recebe o que será filtrado
     {
        var objetos = from m in db.Objetos select m; //L3 Recebe a tabela inteira e armazena na variavel
        if (!String.IsNullOrEmpty(objetoNome))//L4 Se o filtro estiver vazio entao irá mostrar todos os objetos
        {
            objetos = objetoss.Where(s => s.Nome.Contains(nomeObjeto));//L6 Filtra a lista, buscando apenas objetos com o mesmo nome da pesquisa
        }
        return View(objetos);
     }

   
    
    
    
