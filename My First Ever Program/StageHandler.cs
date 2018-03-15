namespace My_First_Ever_Program
{
    internal class StageHandler : IStageHandler
    {
        protected string CurrentStagePrompt = "This is yet to be set [ StageHandler.cs Line 5]";

        public string GetCurrentStage()
        {
            return CurrentStagePrompt;
        }
    }
}