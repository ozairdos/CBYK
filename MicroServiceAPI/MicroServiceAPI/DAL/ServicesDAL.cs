using MicroServiceAPI.DTO;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MicroServiceAPI.DAL
{
    public class ServicesDAL
    {
        private SQLiteConnection conexao;
        public Task<bool> ConexaoSQLite()
        {
            return Task.Factory.StartNew(() =>
            {
                try
                {
                    bool pasta = Directory.Exists(System.Environment.CurrentDirectory);
                    if (!pasta)
                        Directory.CreateDirectory(System.Environment.CurrentDirectory);

                    String _conexao = System.IO.Path.Combine(System.Environment.CurrentDirectory, "Services.db");

                    conexao = new SQLiteConnection(_conexao);

                    conexao.CreateTable<Services>();

                    return true;
                }
                catch
                {
                    return false;
                }
            });
        }
        public Task<Int32> Inserir(Services services)
        {
            return Task.Factory.StartNew(() =>
            {
                return conexao.Insert(services);
            });
        }        
        public Task<Services> ConsultarPorRequisicao(string requisicao)
        {
            return Task.Factory.StartNew(() =>
            {
                return conexao.Table<Services>().FirstOrDefault(c => c.Requisicao == requisicao);
            });
        }
        public Task<List<Services>> ConsultarEnvios()
        {
            return Task.Factory.StartNew(() =>
            {
                return conexao.Table<Services>().ToList();
            });
        }
        public Task<int> ConsultarTotalEnvios()
        {
            return Task.Factory.StartNew(() =>
            {
                return conexao.Table<Services>().ToList().Count;
            });
        }
        public void DeletarTabela()
        {
            Task.Factory.StartNew(() =>
            {
                conexao.DropTable<Services>();
            });
        }
    }
}
