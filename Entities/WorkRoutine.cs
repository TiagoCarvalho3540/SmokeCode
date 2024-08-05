using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokeMaker.Entities
{
    public class WorkRoutine
    {
        public required int WorkRoutineId { get; set; }

        public required List<WebInteration> Interations { get; set; }

        public required string Author { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModification { get; set; }

    }
}
