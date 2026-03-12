using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOLIST
{
    public class TaskItem
    {
        public string Name { get; set; } = string.Empty;
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            var status = IsCompleted ? "(Completed)" : "(In Process)";
            return $"{Name} - Deadline: {Deadline.ToShortDateString()} {status}";
        }
    }
}
