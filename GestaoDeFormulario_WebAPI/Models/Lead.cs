namespace GestaoDeFormulario_WebAPI.Models
{
    public class Lead
    {
        public Lead()
        {
            //leads está vinculado com reunião
            LeadsReuniao = new List<LeadAgendarReuniao>();
        }
        public Lead(int id, string nomeDaEmpresa, string cep, string logradouro, string numero, string bairro, string cidade, string estado, string email, string telefone, string contato, string detalhes)
        {
            this.id = id;
            this.nomeDaEmpresa = nomeDaEmpresa;
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;            
            this.email = email;
            this.telefone = telefone;
            this.contato = contato;
            this.detalhes = detalhes;
        }

        public int id { get; set; }
        public string nomeDaEmpresa { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string contato { get; set; }
        public string detalhes { get; set; }
        public IEnumerable<LeadReuniao>? LeadsReuniao { get; set; }   


    }
}
