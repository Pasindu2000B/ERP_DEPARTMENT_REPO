namespace ERP.Domain.Core.Entity.StudentEntity
{
    public class Batch
    {
        public int BatchId { get; set; }
        public string BatchName { get; set; } = string.Empty;
        public DateOnly StartDate { get; set; }

    }
}