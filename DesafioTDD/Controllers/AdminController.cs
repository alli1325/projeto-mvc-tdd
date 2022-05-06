using System.Linq;
using DesafioTDD.Data;
using DesafioTDD.Dependencies;
using DesafioTDD.DTO;
using DesafioTDD.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTDD.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDBContext database;

        public AdminController(ApplicationDBContext database){
            this.database = database;

        }

        [HttpPost]
        public IActionResult Atualizar(CaixaDTO caixaTemp){
            if(ModelState.IsValid){
                Metodos method = new Metodos();
                var caixa = database.Caixas.First();

                method.SetNotas(caixa, caixaTemp);
                
                database.SaveChanges();

                return RedirectToAction("Admin", "ATM", new AdminDTO{User = "admin", Senha = "admin"});    

            }else{
                return View("../ATM/Admin");
            }
        }
    }
}