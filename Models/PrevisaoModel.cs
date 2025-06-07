using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HttpProjeto.Models
{
    public class PrevisaoModel
    {
        public string Cidade;
        public string Estado;
        public string AtualizadoEm;
        public List<Clima> Clima;
    }
}
