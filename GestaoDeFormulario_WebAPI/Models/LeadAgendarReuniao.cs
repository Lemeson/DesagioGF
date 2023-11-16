namespace GestaDeFormulario_WebAPI.Models
{
    public class LeadReuniao
    {
        public LeadReuniao()
        {
            
        }
        public LeadReuniao(int leadId, int agendarReuniaoId)
        {
            this.leadId = leadId;
            this.agendarReuniaoId = agendarReuniaoId;
        }

        public int leadId { get; set; }
        public Lead lead { get; set; }
        public int agendarReuniaoId { get; set; }
        public AgendarReuniao AgendarReuniao { get; set; }
    }
}
