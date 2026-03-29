using System.Linq;

namespace MidExam_991483963_JobBoardApp.Models
{
    public class Repository
    {
        public static List<JobPosting> JobPostings = new List<JobPosting>()
        {
            new JobPosting
            {
                Id = 1,
                JobTitle = "Junior Web Dev",
                Department = "Engineering",
                ClosingDate = DateTime.Now.AddDays(10)
            },
            new JobPosting
            {
                Id = 2,
                JobTitle = "HR Coordinator",
                Department = "Human Resources",
                ClosingDate = DateTime.Now.AddDays(20)
            },
            new JobPosting
            {
                Id = 3,
                JobTitle = "Senior Analyst",
                Department = "Finance",
                ClosingDate = DateTime.Now.AddDays(-1) // yesterday = CLOSED
            }
        };

        // REQUIRED method signature
        public static void AddApplication(int jobId, Applicant applicant)
        {
            JobPosting job = JobPostings.FirstOrDefault(j => j.Id == jobId);
            if (job != null)
            {
                job.Applications.Add(applicant);
            }
        }

        // Helper (not required, but useful)
        public static JobPosting GetJobById(int id)
        {
            return JobPostings.FirstOrDefault(j => j.Id == id);
        }
    }
}
