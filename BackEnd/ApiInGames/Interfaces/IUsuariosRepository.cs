using ApiInGames.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInGames.Interfaces
{
    interface IUsuariosRepository
    {
        List<Usuarios> Listar();

        Usuarios BuscarPorId(int id);

        void Cadastrar(Usuarios novoUsuario);

        void Deletar(int id);

        void Atualizar(int id, Usuarios usuarios);

        List<Usuarios> ListarComTipoUsuarios();
    }
}
