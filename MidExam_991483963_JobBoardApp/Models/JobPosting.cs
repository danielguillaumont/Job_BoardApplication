namespace MidExam_991483963_JobBoardApp.Models
{
    public class JobPosting
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public DateTime ClosingDate { get; set; }

        public List<Applicant> Applications { get; set; } = new List<Applicant>();

        // Read-only logic property
        public bool IsOpen
        {
            get { return DateTime.Now < ClosingDate; }
        }
    }
}

