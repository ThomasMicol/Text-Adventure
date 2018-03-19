namespace My_First_Ever_Program
{
    internal class Biome : IBiome
    {
        protected string Name;
        protected string ResourceSet;
        protected string StageSet;
        protected string Descriptor;

        public Biome(string aName, string aResourceSet, string aStageSet, string aDescriptor)
        {
            this.Name = aName;
            this.ResourceSet = aResourceSet;
            this.StageSet = aStageSet;
            this.Descriptor = aDescriptor;
        }

        public string GetName() { return Name; }
        public string GetResourceSetPath() { return ResourceSet; }
        public string GetStageSetPath() { return StageSet; }
        public string GetDescriptor() { return Descriptor; }
    }
}