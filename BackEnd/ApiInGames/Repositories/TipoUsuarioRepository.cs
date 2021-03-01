using ApiInGames.Domains;
using ApiInGames.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInGames.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        InGamesContext ctx = new InGamesContext();

        public TipoUsuario BuscarPorId(int id)
        {
            return ctx.TipoUsuario.FirstOrDefault(e => e.IdTipoUsuario == id);
        }

        public void Cadastrar(TipoUsuario novoTipo)
        {
            ctx.TipoUsuario.Add(novoTipo);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TipoUsuario tipoApagado = new TipoUsuario();
            tipoApagado = BuscarPorId(id);
            ctx.TipoUsuario.Remove(tipoApagado);
            ctx.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuario.ToList();
        }
    }
}
