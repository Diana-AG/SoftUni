namespace Suls.Services
{
    using Suls.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SubmissionsService : ISubmissionsService
    {
        private readonly ApplicationDbContext db;
        private readonly Random random;

        public SubmissionsService(ApplicationDbContext db, Random random)
        {
            this.db = db;
            this.random = random;
        }
        public void Create(string problemId, string userId, string code)
        {
            var problemMaxPionts = this.db.Problems
                .Where(x => x.Id == problemId)
                .Select(x => x.Points)
                .FirstOrDefault();

            var submission = new Submission
            {
                Code = code,
                UserId = userId,
                ProblemId = problemId,
                AchievedResult = (ushort)random.Next(0, problemMaxPionts + 1),
                CreatedOn = DateTime.UtcNow,
            };

            this.db.Submissions.Add(submission);
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            var submission = this.db.Submissions.Find(id);
            this.db.Submissions.Remove(submission);
            this.db.SaveChanges();
        }
    }
}
