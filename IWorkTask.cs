namespace FutureFarm
{
    public interface IWorkTask
    {
        void Cut(string vegetable, string tool);
        void Harvest(string vegetable, string tool);
        void GiveWater(string target);
    }
}
