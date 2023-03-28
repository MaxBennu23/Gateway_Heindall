namespace Gateway_Heindall.Models
{
    public class IntegradordoUser
    {
        public int Id { get; set; }
        public string IntegradorNome { get; set; }
        public string UsuarioIDAgencia { get; set; }
        public string GrupoUser { get; set; }
        public string GrupoPassword { get; set; }
        public int GrupoPort { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }

        public int IntegradorId { get; set; }
        public Integrador Integrador { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}
