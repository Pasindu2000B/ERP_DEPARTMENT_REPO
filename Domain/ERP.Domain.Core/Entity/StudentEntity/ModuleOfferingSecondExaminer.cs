namespace ERP.Domain.Core.Entity.StudentEntity
{
    public class ModuleOfferingSecondExaminer
    {
        public int ModuleOfferingId { get; set; }
        public ModuleOffering ModuleOffering { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}