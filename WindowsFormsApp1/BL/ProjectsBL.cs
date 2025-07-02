using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BL
{
    public class ProjectsBL
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ProjectsBL(int projectID, string title, string description)
        {
            this.ProjectID = projectID;
            this.Title = title;
            this.Description = description;
        }
        public ProjectsBL(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }
    }
}
