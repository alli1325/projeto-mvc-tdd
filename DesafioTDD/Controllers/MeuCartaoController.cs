using System;
using System.Collections.Generic;
using System.Linq;
using DesafioTDD.Data;
using DesafioTDD.Dependencies;
using DesafioTDD.DTO;
using DesafioTDD.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesafioTDD.Controllers
{
    public class MeuCartaoController : Controller
    {
        private readonly ApplicationDBContext database;

        public MeuCartaoController(ApplicationDBContext database){
            this.database = database;
        }

        

        [HttpPost]
        public IActionResult Saque(SaqueDTO saque){
            if(ModelState.IsValid){
                var cartao = database.Cartoes.First(f => f.Numero == saque.Numero);
                var caixa = database.Caixas.First();
                var numero = saque.Numero.Replace(" ","");
                var method = new Metodos();

                //Verifica se terminal possui notas suficientes, este terminal funciona com
                //no minimo de 5 cédulas de cada valor
                if(caixa.Ced100 < 5 ||
                caixa.Ced50 < 5 ||
                caixa.Ced20 < 5 ||
                caixa.Ced10 < 5 )
                {
                    return RedirectToAction("SaqueErro", "ATM", new SaqueDTO{Numero = numero, Saldo = saque.Saldo, Valor = saque.Valor});
                }
                //Aplica contagem de notas necessarias para o saque
                CaixaDTO notas = new CaixaDTO();
                notas = method.ContaNotas(saque.Valor);
                //Altera quantidades das notas no banco
                method.SetNotas(caixa, notas);

                cartao.Saldo = cartao.Saldo - saque.Valor;

                TransacaoDTO transacao = new TransacaoDTO {Numero = numero, Saldo = saque.Saldo, Valor = saque.Valor};
                var extrato = method.GerarExtrato("Saque", cartao, transacao);

                database.Extratos.Add(extrato);
                database.SaveChanges();

                SaqueSucessoDTO sucesso = new SaqueSucessoDTO();
                sucesso.Numero = cartao.Numero;
                sucesso.Ced100 = notas.Ced100;
                sucesso.Ced50 = notas.Ced50;
                sucesso.Ced20 = notas.Ced20;
                sucesso.Ced10 = notas.Ced10;
                sucesso.Total = (notas.Ced100 * 100) + (notas.Ced50 * 50) + (notas.Ced20 * 20) + (notas.Ced10 * 10);

                return RedirectToAction("SaqueSucesso", "ATM", sucesso);

            }else{
                var numero = saque.Numero.Replace(" ","");
                return View("../ATM/Sacar", new SaqueDTO{Numero = numero, Saldo = saque.Saldo, Valor = saque.Valor});
            }
        }

        [HttpPost]
        public IActionResult Deposito(DepositoDTO deposito){
            if(ModelState.IsValid){
                var cartao = database.Cartoes.First(f => f.Numero == deposito.Numero);
                var numero = deposito.Numero.Replace(" ","");
                var method = new Metodos();

                cartao.Saldo = cartao.Saldo + deposito.Valor;

                TransacaoDTO transacao = new TransacaoDTO {Numero = numero, Saldo = deposito.Saldo, Valor = deposito.Valor};
                var extrato = method.GerarExtrato("Depósito", cartao, transacao);

                database.Extratos.Add(extrato);
                database.SaveChanges();
                
                return RedirectToAction("MeuCartao", "ATM", new LoginDTO{Numero = cartao.Numero, Senha = cartao.Senha});    
    
            }else{
                var numero = deposito.Numero.Replace(" ","");
                return View("../ATM/Sacar", new SaqueDTO{Numero = numero, Saldo = deposito.Saldo, Valor = deposito.Valor});
            }
    
        }
        
    }
}