namespace Suls.Services
{
    using Suls.ViewModels.Problems;

    public interface IProblemsService
    {
        void Create(string name, ushort points);

        IEnumerable<HomePageProblemViewModel> GetAll();

        string GetNameById(string id);

        ProblemViewModel GetById(string id);
    }
}
