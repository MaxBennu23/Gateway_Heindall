namespace Gateway_Heindall.Models
{
    public class IntegradordoUserTemp
    {
        public int Id { get; set; }
        public string IntegradorNomeTemp { get; set; }
        public string UsuarioIDAgenciaTemp { get; set; }
        public string GrupoUserTemp { get; set; }
        public string GrupoPasswordTemp { get; set; }
        public int GrupoPortTemp { get; set; }
        public string PublicKeyTemp { get; set; }
        public string PrivateKeyTempTemp { get; set; }

        public int IntegradorId { get; set; }
        public Integrador Integrador { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
