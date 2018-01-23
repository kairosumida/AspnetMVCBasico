<h1>Aula07</h1>
<h3>Recebendo informação da View para a Controller</h3>
<br>
<h2>Controller</h2>
<p>string msg = Request["txtMsg"].ToString(); //Recebe a msg da View</p>
<p>ViewBag.Msg = msg; //Envia a mensagem para a View</p>

<h2>View</h2>


      using(Html.BeginForm("NovoMetodo", "Controller")//Chama o novo método, que irá ler o txtMsg
      {
        @Html.TextBox("txtMsg") //txtMsg é o nome que será acessado pelo controler usando o Request
        <input type="submit" value="Entrar" />
      }
