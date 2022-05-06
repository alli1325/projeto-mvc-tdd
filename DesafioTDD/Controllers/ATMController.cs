using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DesafioTDD.Models;
using DesafioTDD.DTO;
using DesafioTDD.Data;

namespace DesafioTDD.Controllers
{
    public class ATMController : Controller
    {
        private readonly ApplicationDBContext database;

        public ATMController(ApplicationDBContext database){
            this.database = database;
        }

        public IActionResult MeuCartao(LoginDTO login)
        {
            if(ModelState.IsValid){
                var acesso = database.Cartoes.Where(f => f.Status == true).FirstOrDefault(f => f.Numero == login.Numero);

                if(acesso != null && acesso.Senha == login.Senha)
                {
                    CartaoDTO cartaoView = new CartaoDTO();
                    cartaoView.Numero = $"{acesso.Numero.Substring(0, 4)} {acesso.Numero.Substring(4, 4)} {acesso.Numero.Substring(8, 4)} {acesso.Numero.Substring(12, 4)}";
                    cartaoView.Saldo = acesso.Saldo;
                    cartaoView.Extrato = new List<ExtratoDTO>();
            
                    var extratos = database.Extratos.Where(f => f.Cartao.Id == acesso.Id).ToList();

                    foreach(var registro in extratos)
                    {
                        ExtratoDTO notas = new ExtratoDTO();
                        notas.Tipo = registro.Tipo;
                        notas.Valor = registro.Valor;
                        notas.Data = registro.Data;

                        cartaoView.Extrato.Add(notas);
                    }
                    cartaoView.Extrato.Reverse();

                    return View(cartaoView);
                }else{
                    return RedirectToAction("MeuCartaoErro", "ATM");
                }

            }else
                return View("../Home/Index");
        }

        public IActionResult MeuCartaoErro()
        {
            return View();
        }

        public IActionResult Depositar(string numeroCartao)
        {
            if(numeroCartao != null){
                var acesso = database.Cartoes.Where(f => f.Status == true).FirstOrDefault(f => f.Numero == numeroCartao);

                if(acesso != null)
                {
                    DepositoDTO cartaoView = new DepositoDTO();
                    cartaoView.Numero = $"{acesso.Numero.Substring(0, 4)} {acesso.Numero.Substring(4, 4)} {acesso.Numero.Substring(8, 4)} {acesso.Numero.Substring(12, 4)}";
                    cartaoView.Saldo = acesso.Saldo;
                    cartaoView.Valor = 0;
            
                    return View(cartaoView);
                }else{
                   return RedirectToAction("Index", "Home");
                }
            }else{
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Sacar(string numeroCartao)
        {
            if(numeroCartao != null){
                var acesso = database.Cartoes.Where(f => f.Status == true).FirstOrDefault(f => f.Numero == numeroCartao);

                if(acesso != null)
                {
                    SaqueDTO cartaoView = new SaqueDTO();
                    cartaoView.Numero = $"{acesso.Numero.Substring(0, 4)} {acesso.Numero.Substring(4, 4)} {acesso.Numero.Substring(8, 4)} {acesso.Numero.Substring(12, 4)}";
                    cartaoView.Saldo = acesso.Saldo;
                    cartaoView.Valor = 0;
                    
                    return View(cartaoView);
                }else{
                   return RedirectToAction("Index", "Home");
                }
            }else{
                return RedirectToAction("Index", "Home");
            }
        }
        
        public IActionResult SaqueSucesso(SaqueSucessoDTO caixa)
        {
            return View(caixa);
        }

        public IActionResult SaqueErro(SaqueDTO saque)
        {
            return View(saque);
        }

        public IActionResult HabilitarCartao()
        {
            return View();
        }

        public IActionResult CartaoCadastradoSucesso()
        {
            return View();
        }

        public IActionResult CartaoJaCadastrado()
        {
            return View();
        }

        public IActionResult AcessoAdm()
        {
            return View();
        }

        public IActionResult AcessoAdmErro()
        {
            return View();
        }

        public IActionResult Admin(AdminDTO admin)
        {
            if(ModelState.IsValid){
                var acesso = database.Administradores.FirstOrDefault(f => f.User == admin.User);

                if(acesso != null && acesso.Senha == admin.Senha)
                {
                    var notas = database.Caixas.First();
                    CaixaDTO notasView = new CaixaDTO();
                    notasView.Ced100 = notas.Ced100;
                    notasView.Ced50 = notas.Ced50;
                    notasView.Ced20 = notas.Ced20;
                    notasView.Ced10 = notas.Ced10;
                    notasView.Total = notas.Total;
                    notasView.TotalString = $"R$ {notas.Total}";

                    return View(notasView);
                }else{
                    return RedirectToAction("AcessoAdmErro", "ATM");
                }
            }else{
                return View("../ATM/AcessoAdm");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
