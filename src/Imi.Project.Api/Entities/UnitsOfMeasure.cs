namespace Imi.Project.Api.Entities
{
    public class UnitsOfMeasure
    {
        // This class only contains units of measure (gram, liter, etc.) and will not inherit BaseEntity as users will not create units on their own

        public string MeasureUnit { get; set; }
    }
}
