namespace Gateway_Heindall.Models
{
    public class ConfigGeral
    {
        public int Id { get; set; }
        
        public string ConfigType { get; set; }

        public string ConfigNomeDoRecurso { get; set; }

        public string FrequenciaCronJob { get; set; } //de quanto em quanto tempo chama a API

        public bool TrazOsCancelados { get; set; }

    }
}
