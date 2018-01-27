
<h1>Aula 6</h1>
<h2>Add objetos no banco de dados</h2>
<p>Tem como objetivo cadastrar um objeto no banco de dados. Para criar um objeto e adicioná-lo ao banco de dados é necessário criar 1 view e 1 método na Controller
<h4>Controller</h4>


 	public ActionResult Create()
        {
            return View();
        }        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeObjeto")] Objeto objeto)
        {
            if (ModelState.IsValid)
            {
                db.Objetos.Add(objeto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objeto);
        }
				
				
<h4>View</h4>

	@using (Html.BeginForm()) 
	{
    @Html.AntiForgeryToken()
    
    <div class="form-horizontal">
        <h4>Objetos</h4>
        <hr />
        @Html.ValidationSummary(true, "", new { @class = "text-danger" })
        <div class="form-group">
            @Html.LabelFor(model => model.NomeObjeto, htmlAttributes: new { @class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.NomeObjeto, new { htmlAttributes = new { @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.NomeObjeto, "", new { @class = "text-danger" })
            </div>
        </div>
