using System.ComponentModel.DataAnnotations.Schema;

namespace SourcingAPI.Models
{
    [Table("sourcinghandover")] // This matches your manual PostgreSQL table name
    public class SourcingItem
    {
        public int Id { get; set; }
        public string SapCode { get; set; } = "";
        public string Description { get; set; } = "";
        public string DrawingRevision { get; set; } = "";
        public string Commodity { get; set; } = "";
        public string Supplier { get; set; } = "";
        public string BuyerCST { get; set; } = "";
        public string ApplicationProduct { get; set; } = "";

        // ADD THESE MISSING COLUMNS
        public string CustomerCode { get; set; } = "";
        public bool CostingSheet { get; set; } = false;
        public string ToolCostStatus { get; set; } = "";
        public string DualSource { get; set; } = "";
        public string SaReleasedNumber { get; set; } = "";
        public string Remarks { get; set; } = "";

        public bool IsirDocuments { get; set; } = false;
        public bool PpapDocument { get; set; } = false;
    }
}