<h1>Aula07</h1>
<h2>Recebendo informação da View para a Controller</h3>
<br>
<h4>Controller</h4>

      string msg = Request["txtMsg"].ToString(); //Recebe a msg da View
      ViewBag.Msg = msg; //Envia a mensagem para a View

<h4>View</h4>


      using(Html.BeginForm("NovoMetodo", "Controller")//Chama o novo método, que irá ler o txtMsg
      {
        @Html.TextBox("txtMsg") //txtMsg é o nome que será acessado pelo controler usando o Request
        <input type="submit" value="Entrar" />
      }

<h2>Outras alternativas</h2>
<p>É possivel tambem enviar os dados da View para a Controller, passando como parametros na função</p>
<h4>Controller</h4

      public ActionResult Index(string txtMsg)
      {

      }
<h4>View</h4>

      using(Html.BeginForm("Index", "Controller")//Chama o método, que irá ler o txtMsg
      {
        @Html.TextBox("txtMsg") //txtMsg é o nome que será enviado pelos parametros do método
        <input type="submit" value="Entrar" />
      }
