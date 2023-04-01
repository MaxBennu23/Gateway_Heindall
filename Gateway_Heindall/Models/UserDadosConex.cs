namespace Gateway_Heindall.Models
{
    public class UserDadosConex
    {
        public int Id { get; set; }     
        public string UserCNPJ { get; set; }
        public string UserNivel { get; set; }
        public string UserNomeEmpresa { get; set; }
        public string UserHostDestino { get; set; }
        public string UserHostUserDestino { get; set; }
        public string UserSenhaDestino { get; set; }
        public string UserPortDestino { get; set; }
        public string UserBancoDestino { get; set; }

       public ICollection<IntegradordoUser> IntegradoresdoUser { get; set; }
       
    }
}
