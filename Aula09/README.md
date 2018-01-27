
<h1>Aula 09</h1>
<h3>Populando uma dropdownlist</h3>
<p>Busca no banco de dados todos os nomes em uma coluna, separa cada diferente e adiciona a List, envia por uma ViewBag que adiciona uma DropDownList na View</p>
<h4>Controller</h4>
 
       var listaNome = new List<string>();
       var m = from d in db.Objetos orderby d.Nome select d.Nome;//Busca no banco todas os nomes
       listaNomes.AddRange(m.Distinct());//Separa os nomes repetidos e descarta
       ViewBag.Nome = new SelectList(listaNome); //Envia para a view com base no nome do dropdown
       
 <h4>View</h4>
 
      @Html.DropDownList("Nome")
      
      
      
<h3>Usando Enums</h3>      
<p>Para utilizar enums é a mesma coisa, mudando apenas </p>

       var m = from d in db.Objetos orderby d.Nome select d.Nome;
       var m = from d in db.Objetos orderby d.Nome.ToString() select d.Nome.ToString();
