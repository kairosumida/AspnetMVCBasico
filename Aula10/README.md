<h1>Aula10</h1>
<h2>Data Annotations</h2>
<p>É um recurso que permite atribuir regras a um respectivo campo, como numero maximo, letras permitidas, ou formato de datas</p>

<h4>Campo obrigatório</h4>
<code>[Required(ErrorMessage="Favor colocar o nome!")]</code>
 
<h4>Número deve estar entre os intervalos</h4>
<code>[Range(typeof(decimal), "10", "1000", ErrorMessage ="O preço deve de 10 a 1000")]</code>
 
<h4>É permitido apenas as letras</h4>
<code>[RegularExpression(@"[ABC]", ErrorMessage = "Digite apenas A, B ou C")]</code>
 
<h4>Deve ter a quantidade de caracteres</h4>
<code>[StringLength(20, ErrorMessage ="O nome deve ter de 5 a 20 caracteres", MinimumLength =5)]</code>
 
<h4>O formato deve ser 5 digitos - 3 digitos ou 8 digitos</h4>
<code>[RegularExpression(@"\d{5}-\d{3}|\d{8}", ErrorMessage ="Utilize o formato 00000-000 ou 000000000")]</code>
 
<h4>Campo do tipo email, com @ e .com</h4>
<code>[EmailAddress(ErrorMessage = "Email incorreto")]</code>

<h4>Campo do tipo password, não mostra os dados</h4>
<code>[DataType(DataType.Password)]</code>
 
<h4>Compara um campo com outro</h4>
<code>[Compare("Senha", ErrorMessage = "A senha e a confirmação da senha são diferentes")]</code>
