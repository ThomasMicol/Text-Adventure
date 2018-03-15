namespace My_First_Ever_Program
{
    internal class StageHandler : IStageHandler
    {
        protected string CurrentStagePrompt;

        public string GetCurrentStage()
        {
            return CurrentStagePrompt;
        }
    }
}