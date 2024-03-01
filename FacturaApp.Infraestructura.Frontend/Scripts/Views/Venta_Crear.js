

////Guarda producto actual

//const formulario = document.querySelector('#formulario');
//const listaResultados = document.querySelector('#lista-resultados');

//formulario.addEventListener('submit', (event) => {
//    event.preventDefault();

//    const Codigo = document.querySelector('#Codigo').value;
//    const Descripcion = document.querySelector('#Descripcion').value;
//    const Categoria = document.querySelector('#Categoria').value;

//    const listaDatos = [
//        {
//            "Codigo": Codigo,
//            "Descripcion": Descripcion,
//            "Categoria": Categoria
//        }
//    ];

//    const htmlLista = listaDatos.map(item => `

//    <div class="row">

//        <div class="col-sm-4">
//            <div class="form-group mb-0">
//                <input type="text" class="form-control form-control-sm model" readonly id="Descripcion" name="Codigo" value="${item.Codigo}">
//            </div>
//        </div>

//        <div class="col-sm-4">
//            <div class="form-group mb-0">
//                <input type="text" class="form-control form-control-sm model" readonly id="Descripcion" name="Descripcion" value="${item.Descripcion}">
//            </div>
//        </div>

//        <div class="col-sm-4">
//            <div class="form-group mb-0">
//                <input type="text" class="form-control form-control-sm model" readonly id="Categoria" name="Categoria" value="${item.Categoria}">
//            </div>
//        </div>
    
//    </div>
//    `).join('');



//    listaResultados.innerHTML = htmlLista;

//});