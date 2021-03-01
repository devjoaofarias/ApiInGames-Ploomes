using ApiInGames.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInGames.Interfaces
{
    interface IJogoRepository
    {
        List<Jogo> Listar();

        Jogo BuscarPorId(int id);

        void Cadastrar(Jogo novoJogo);

        void Deletar(int id);

        void Atualizar(int id, Jogo jogo);

        List<Jogo> ListarComEstudios();
    }
}
