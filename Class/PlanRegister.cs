namespace Meta_xi.Application;
public class PlanRegister
{
    public required string Name { get; set; }
    public required double Price { get; set; }
    public required int MaxQuantity { get; set; }
    public required int DaysActive { get; set; }
    public required double DailyBenefit { get; set; }
    public required double TotalBenefit { get ; set ; }
}