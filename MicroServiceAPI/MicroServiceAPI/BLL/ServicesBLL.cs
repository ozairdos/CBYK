using MicroServiceAPI.DAL;
using MicroServiceAPI.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroServiceAPI.BLL
{
    public class ServicesBLL
    {
        public async Task<string> Inserir(string value, string identificador)
        {
            try
            {                
                Services services = new Services();
                ServicesDAL servicesDAL = new ServicesDAL();
                var rng = new Random();
                services.Mensagem = value;
                services.Identificador = identificador;
                services.Timestamp = DateTime.Now;
                services.Requisicao = rng.Next().ToString();

                bool statusConexao = await servicesDAL.ConexaoSQLite();
                if (statusConexao)
                {
                    await servicesDAL.Inserir(services);
                    return services.Requisicao;
                }                    
                else
                    return null;
            }
            catch
            {
                return "Erro";
            }
        }
        public async Task<Services> ConsultarPorRequisicao(string requisicao)
        {
            try
            {
                Services service = new Services();
                ServicesDAL servicesDAL = new ServicesDAL();

                bool statusConexao = await servicesDAL.ConexaoSQLite();
                if (statusConexao)
                    return await servicesDAL.ConsultarPorRequisicao(requisicao);
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }
        public async Task<List<Services>> ConsultarEnvios()
        {
            try
            {
                List<Services> services = new List<Services>();
                ServicesDAL servicesDAL = new ServicesDAL();

                bool statusConexao = await servicesDAL.ConexaoSQLite();
                if (statusConexao)
                    return await servicesDAL.ConsultarEnvios();
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }
        public async Task<int> ConsultarTotalEnvios()
        {
            try
            {
                List<Services> services = new List<Services>();
                ServicesDAL servicesDAL = new ServicesDAL();

                bool statusConexao = await servicesDAL.ConexaoSQLite();
                if (statusConexao)
                    return await servicesDAL.ConsultarTotalEnvios();
                else
                    return 0;
            }
            catch
            {
                return 0;
            }
        }
        public async Task<string> ZerarBase()
        {
            try
            {
                List<Services> services = new List<Services>();
                ServicesDAL servicesDAL = new ServicesDAL();

                bool statusConexao = await servicesDAL.ConexaoSQLite();
                if (statusConexao)
                {
                    servicesDAL.DeletarTabela();
                    return "Sucesso";
                }
                else
                    return "Erro";
            }
            catch
            {
                return "Erro";
            }
        }
    }
}
