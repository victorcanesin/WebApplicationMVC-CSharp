namespace WebApplicationMVC1.Models
{
    public class Cidade
    {
        public short cidadeCodigo { get; set; }

        public string cidadeDescricao { get; set;}

        public short estadoCodigo { get; set; }

        public Estado estado { get; set; }  
    
    }
}