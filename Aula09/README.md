 <h1>Aula 09</h1>
 <h3>Busca varios nomes no BD e seleciona cada nome diferente e popula uma dropdownlist</h3>

 <h4>Controller</h4>
 
       var listaNome = new List<string>();
       var m = from d in db.Objetos orderby d.Nome select d.Nome;//Busca no banco todas os nomes
       listaNomes.AddRange(m.Distinct());//Separa os nomes repetidos e descarta
       ViewBag.Nome = new SelectList(listaNome); //Envia para a view com base no nome do dropdown
       
 <h4>View</h4>
 
      @Html.DropDownList("Nome")
      
      
      
      
<p>Para utilizar enums é a mesma coisa, mudando apenas </p>

       var m = from d in db.Objetos orderby d.Nome select d.Nome;
       var m = from d in db.Objetos orderby d.Nome.ToString() select d.Nome.ToString();
