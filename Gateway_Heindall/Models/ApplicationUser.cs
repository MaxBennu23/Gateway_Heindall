using Microsoft.AspNetCore.Identity;

namespace Gateway_Heindall.Models
{
    public class ApplicationUser : IdentityUser
    {
        public new int Id { get; set; }
        public string UserCNPJ { get; set; }
        public string UserNivel { get; set; }
        public string UserNomeEmpresa { get; set; }
        public string UserHost { get; set; }
        public string UserHostUser { get; set; }
        public string UserSenha { get; set; }
        public string UserPort { get; set; }
        public string UserBancoDestino { get; set; }

        public ICollection<Integrador> Integradores { get; set; }


    }
}
