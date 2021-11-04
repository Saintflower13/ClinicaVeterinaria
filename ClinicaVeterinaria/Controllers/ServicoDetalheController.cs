using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria.Controllers
{
    public class ServicoDetalheController : BaseNotifyPropertyChanged
    {
        private ServicoDetalhes _servicoDetalhes;
        public ServicoDetalhes ServicoDetalhado
        {
            get { return _servicoDetalhes; }
            set { SetField(ref _servicoDetalhes, value); }
        }

        public ServicoDetalheController(object servicoDetalhe)
        {
            ServicoDetalhado = (ServicoDetalhes)servicoDetalhe;
        }

        public bool ConcluirServico()
        {
            try
            {
                ServicoDetalhado.ServicoDetalhado.Status = true;
                ServicoDetalhado.ServicoDetalhado.DataFim = System.DateTime.Now;
                Servico.Salvar(ServicoDetalhado.ServicoDetalhado);
                ResetarServicoDetalhe();
                return true;
            } catch
            {
                return false;
            }
        }

        private void ResetarServicoDetalhe()
        {
            int servicoId = ServicoDetalhado.ServicoDetalhado.Id;
            Servico servico = Servico.BuscarPorId(servicoId);

            ServicoDetalhado = null;
            ServicoDetalhado = new ServicoDetalhes(servico);
        }
    }
}
