using ApiInGames.Domains;
using ApiInGames.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInGames.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        InGamesContext ctx = new InGamesContext();

        public void Atualizar(int id, Jogo jogo)
        {
            Jogo jogoAtualizado = new Jogo();
            jogoAtualizado = BuscarPorId(id);

            jogoAtualizado.DataDeLancamento = jogo.DataDeLancamento;
            jogoAtualizado.Descricao = jogo.Descricao;
            jogoAtualizado.IdEstudio = jogo.IdEstudio;
            jogoAtualizado.IdEstudioNavigation = jogo.IdEstudioNavigation;
            jogoAtualizado.Valor = jogo.Valor;

            ctx.Jogo.Update(jogoAtualizado);
            ctx.SaveChanges();
        }

        public Jogo BuscarPorId(int id)
        {
            return ctx.Jogo.FirstOrDefault(e => e.IdJogo == id);
        }

        public void Cadastrar(Jogo novoJogo)
        {
            ctx.Jogo.Add(novoJogo);
            ctx.SaveChanges();
        }


        public void Deletar(int id)
        {
            Jogo jogoApagado = new Jogo();
            jogoApagado = BuscarPorId(id);
            ctx.Jogo.Remove(jogoApagado);
            ctx.SaveChanges();
        }

        public List<Jogo> Listar()
        {
            return ctx.Jogo.ToList();
        }

        public List<Jogo> ListarComEstudios()
        {
            return ctx.Jogo.Include(e => e.IdEstudioNavigation).ToList();
        }
    }
}

