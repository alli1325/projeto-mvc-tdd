using System.Linq;
using DesafioTDD.Data;
using DesafioTDD.Dependencies;
using DesafioTDD.DTO;
using DesafioTDD.Models;
using DesafioTDD.Validations;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTDD.Controllers
{
    public class HabilitarCartaoController : Controller
    {
        private readonly ApplicationDBContext database;

        public HabilitarCartaoController(ApplicationDBContext database){
            this.database = database;

        }

        [HttpPost]
        public IActionResult Salvar(HabilitarCartaoDTO cartaoTemp){
            if(ModelState.IsValid){
                var cartao = database.Cartoes.FirstOrDefault(f => f.Numero == cartaoTemp.Numero);
                if(cartao == null) {
                    var method = new Metodos();
                    var novoCartao = method.AtivarCartao(cartaoTemp);

                    database.Cartoes.Add(novoCartao);
                    database.SaveChanges();

                    return RedirectToAction("CartaoCadastradoSucesso", "ATM");
                }else{
                    return View("../ATM/CartaoJaCadastrado");
                }
            }else{
                return View("../ATM/HabilitarCartao");
            }
        }
    }
}