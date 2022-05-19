using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionários
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private AutenticadorHelper _autenticacaoHelper = new AutenticadorHelper();
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf):base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
