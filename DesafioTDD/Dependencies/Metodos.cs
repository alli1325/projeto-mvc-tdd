using System;
using System.Linq;
using DesafioTDD.Data;
using DesafioTDD.DTO;
using DesafioTDD.Models;

namespace DesafioTDD.Dependencies
{
    public class Metodos
    {

        public Metodos()
        {
        }

        public void SetNotas(Caixa caixa, CaixaDTO caixaTemp)
        {    
            caixa.Ced100 = caixaTemp.Ced100;
            caixa.Ced50 = caixaTemp.Ced50;
            caixa.Ced20 = caixaTemp.Ced20;
            caixa.Ced10 = caixaTemp.Ced10;
            caixa.Total = (caixa.Ced100 * 100) + (caixa.Ced50 * 50) + (caixa.Ced20 * 20) + (caixa.Ced10 * 10);
        }

        public Cartao AtivarCartao(HabilitarCartaoDTO cartaoTemp)
        {
            Cartao cartao = new Cartao();
            cartao.Numero = cartaoTemp.Numero;
            cartao.Senha = cartaoTemp.Senha;
            cartao.Saldo = 0;
            cartao.Status = true;

            return cartao;
        }

        public CaixaDTO ContaNotas(double valor)
        {
            CaixaDTO caixa = new CaixaDTO();

            while(valor > 0)
            {
                if(valor >= 100)
                {
                    valor -= 100;
                    caixa.Ced100 += 1;
                }

                if(valor < 100 && valor >= 50)
                {
                    valor -= 50;
                    caixa.Ced50 += 1;
                }

                if(valor < 50 && valor >= 20)
                {
                    valor -= 20;
                    caixa.Ced20 += 1;
                }

                if(valor < 20 && valor > 0)
                {
                    valor -= 10;
                    caixa.Ced10 += 1;
                }
            }

            return (caixa);
        }

        public Extrato GerarExtrato(string tipo, Cartao cartao, TransacaoDTO transacao)
        {
            Extrato extrato = new Extrato();
            extrato.Cartao = cartao;
            extrato.Tipo = tipo;
            extrato.Valor = transacao.Valor;
            extrato.Data = DateTime.Now.ToString().Substring(0, 10);

            return(extrato);
        }
    }
}