using AppModelo.Model.Infra.Repositories;
using AppModelo.Model.Infra.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Seguranca
{
    public class UsuarioController
    {
        public bool EfetuarLogin(string usuario, string senha)
        {
            var repositorio = new UsuarioRepository();

            var usuarioEncontrado = repositorio.Obter(usuario, senha);

            if(usuarioEncontrado is not null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RecuperarSenha(string email)
        {
            // 1º PASSO: VERIFICAR SE O E-MAIL É DE UM USUÁRIO CADASTRADO NO BD.
            var repositorio = new UsuarioRepository();
            var usuario = repositorio.ObterPorEmail(email);
            if (usuario is null)
            {
                return "Usuario não foi encontrado";
            }

            // 2º PASSO: GERAR UMA SENHA NOVA E GRAVAR NO BD.
            var novaSenha = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            var atualizouSenha = repositorio.AtualizarSenha(email, novaSenha);
            if(atualizouSenha is false)
            {
                return "Houve um erro ao alterar sua senha no banco de dados. Ligar para zói -> (027) 99699-2689";
            }

            // 3º PASSO: MANDAR A NOVA SENHA PARA O E-MAIL
            var emailService = new EmailService();
            var mensagemHtml = "<p><b>Criamos uma nova senha para você</b></p><br><p>Sua nova senha é: <b>" + novaSenha + "</b></p>";
            var emailEnviado = emailService.EnviarEmail(usuario.Nome, usuario.Email, "Recuperação de senha", mensagemHtml);

            return "";

        }
    }
}
