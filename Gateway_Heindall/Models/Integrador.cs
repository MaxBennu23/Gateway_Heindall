namespace Gateway_Heindall.Models
{
    public class Integrador
    {
        public int Id { get; set; }
        public string IntegradorNome { get; set; }
        public string IntegradorGrupo { get; set; }
        public string IntegradorEndpoint { get; set; }
        public string IntegradorPublicKey { get; set; }
        public string IntegradorPrivateKey { get; set; }

        public int GrupoId { get; set; } // Chave estrangeira para a entidade Grupo
        public Grupo Grupo { get; set; } // Propriedade de navegação

        public ICollection<IntegradordoUser> IntegradoresdoUser { get; set; }

    }
}
