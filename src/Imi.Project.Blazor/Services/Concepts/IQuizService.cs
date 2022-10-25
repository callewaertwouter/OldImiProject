namespace Imi.Project.Blazor.Services.Concepts
{
    public interface IQuizService
    {
        Task<IQueryable> GetAllQuestions();

        /* Quiz has a number of questions (and several answers to those questions), of which it will pick 5 for the user
         * User answers these 5 questions
         * After 5th question, a score will be displayed to indicate how many user got correct answers
         * TODO: Need to figure out which methods are necessary to achieve this (Google?)
         */
    }
}