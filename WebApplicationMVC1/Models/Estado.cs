namespace WebApplicationMVC1.Models
{
    public class Estado
    {
        public short estadoCodigo { get; set; }

        public string estadoDescricao { get; set; }
        
        public string estadoSigla { get; set; }
        
        public short paisCodigo { get; set; }

        public Pais pais { get; set; }
    }
}
