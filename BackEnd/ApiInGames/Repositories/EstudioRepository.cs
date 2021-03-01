using ApiInGames.Domains;
using ApiInGames.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInGames.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        InGamesContext ctx = new InGamesContext();

        public void Atualizar(int id, Estudio estudio)
        {
            Estudio estudioAtualizado = new Estudio();
            estudioAtualizado = BuscarPorId(id);
            estudioAtualizado.NomeEstudio = estudio.NomeEstudio;
            ctx.Estudio.Update(estudioAtualizado);
            ctx.SaveChanges();
        }

        public Estudio BuscarPorId(int id)
        {
            return ctx.Estudio.FirstOrDefault(e => e.IdEstudio == id);
        }

        public void Cadastrar(Estudio novoEstudio)
        {
            ctx.Estudio.Add(novoEstudio);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Estudio estudioApagado = new Estudio();
            estudioApagado = BuscarPorId(id);
            ctx.Estudio.Remove(estudioApagado);
            ctx.SaveChanges();
        }

        public List<Estudio> Listar()
        {
            return ctx.Estudio.ToList();
        }

        public List<Estudio> ListarJogos()
        {
            return ctx.Estudio.Include(e => e.Jogo).ToList();
        }


    }
}
