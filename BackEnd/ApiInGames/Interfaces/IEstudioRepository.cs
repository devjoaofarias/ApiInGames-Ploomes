using ApiInGames.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInGames.Interfaces
{
    interface IEstudioRepository
    {
        List<Estudio> Listar();
        Estudio BuscarPorId(int id);
        void Cadastrar(Estudio novoEstudio);
        void Deletar(int id);
        void Atualizar(int id, Estudio estudio);
        List<Estudio> ListarJogos();
    }
}
