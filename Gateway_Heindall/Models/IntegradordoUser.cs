namespace Gateway_Heindall.Models
{
    public class IntegradordoUser
    {
        public int Id { get; set; }
        public string UsuarioIDAgencia { get; set; }
        public string IntegUserUser { get; set; }
        public string IntegUserPass { get; set; }
        public int IntegUserPort { get; set; }
        public string IntegUserPublicKey { get; set; }
        public string IntegUserPrivateKey { get; set; }

        public int IntegradorId { get; set; } // Adiciona a propriedade IntegradorId
        public int UserDadosConexId { get; set; }

        public Integrador Integrador { get; set; }
        public UserDadosConex UserDadosConex { get; set; }
        

    }
}
