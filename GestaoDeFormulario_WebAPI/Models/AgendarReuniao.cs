namespace GestaoDeFormulario_WebAPI.Models
{
    public class AgendarReuniao
    {
        public AgendarReuniao()
        {
            
        }

        public AgendarReuniao(int id, string agendarReuniao, string data) //, Professor professor
        {
            this.id = id;
            //this.leadId = leadId;
            this.agendarReuniao = agendarReuniao;
            this.data = data;
            //this.professor = professor;
        }

        public int id { get; set; }
       // public int leadId { get; set; }
        public int agendarReuniao { get; set; }
        public string data {get; set;}
        public Lead lead { get; set; } //prof
        public IEnumerable<LeadReuniao> LeadsAgendarReuniaos { get; set; }

    }
}
