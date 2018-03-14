namespace My_First_Ever_Program
{
    interface IWorldTile
    {
        IInteractable GetInteractable();
        string GetDesciption();
        Biomes GetBiome();
    }
}