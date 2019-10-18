using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Entidades;
using Sistema.Control;

namespace Sistema.Model
{
    public class UsuarioModel
    {
        public static int Inserir(UsuarioEnt objTabela)
        {
            return new UsuarioControl().Inserir(objTabela);
        }

        public List<UsuarioEnt> Lista()
        {
            return new UsuarioControl().Lista();
        }

        public UsuarioEnt Login(UsuarioEnt obj)
        {
            return new UsuarioControl().Login(obj);
        }

        public static int Excluir(UsuarioEnt objTabela)
        {
            return new UsuarioControl().Excluir(objTabela);
        }

        public static int Editar(UsuarioEnt objTabela)
        {
            return new UsuarioControl().Editar(objTabela);
        }

        public List<UsuarioEnt> Buscar(UsuarioEnt objTabela)
        {
            return new UsuarioControl().Buscar(objTabela);
        }
    }
}
