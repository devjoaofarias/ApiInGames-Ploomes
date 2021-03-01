using ApiInGames.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInGames.Interfaces
{
    interface ITipoUsuarioRepository
    {
        List<TipoUsuario> Listar();

        TipoUsuario BuscarPorId(int id);

        void Cadastrar(TipoUsuario novoTipo);

        void Deletar(int id);

        void Atualizar(int id, TipoUsuario tipoUsuario);
    }
}
