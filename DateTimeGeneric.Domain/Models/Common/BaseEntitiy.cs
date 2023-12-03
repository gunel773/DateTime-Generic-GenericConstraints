

namespace DateTimeGeneric.Domain.Models.Common
{
    public class BaseEntitiy
    {
        public int Id  { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }

    }
}
