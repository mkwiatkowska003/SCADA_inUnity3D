using System;

namespace Assets.Srcipts
{
    public interface IData
    {
        char PlantationId { get; set; }
        double Temperature { get; set; }
        double Humadity { get; set; }
        DateTimeOffset SavingDate { get; set; }
    }
}
