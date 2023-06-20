using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_mobile_dono_posto_app.Models.Enuns
{
    public class Enuns
    {

    }
    public enum PerfilEnum
    {
        // Adicione os valores do enum PerfilEnum aqui
        Administrador = 1,
        Cliente = 2,
        DonoPosto = 3,
        FuncionarioPosto = 4
    }

    public enum StatusEnum
    {
        // Adicione os valores do enum StatusEnum aqui
        Pendente = 1,
        Aprovado = 2,
        Reprovado = 3,
        Bloqueado = 4,
        Cancelado = 5
    }
}
