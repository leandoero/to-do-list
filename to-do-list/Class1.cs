using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class ClassForLogic
    {
        private List<string> listForTasks;

        public ClassForLogic() { listForTasks = new List<string>(); }

        public void addTask(string input)
        {
            if (!string.IsNullOrEmpty(input)) {  listForTasks.Add(input); };
        }
        public void removeTask()
        {

        }

        public void printTasks()
        {
            
        }
    }
}
