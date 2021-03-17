using PortfolioCategorize_WinForm.Control;
using System;

namespace PortfolioCategorize_WinForm.Model
{
    class Category
    {
        public string Name { get; }
        public double MinimumValue { get; }
        public double MaximumValue { get; }
        public string ClientSector { get; }

        public Category(string name, double minimumValue, double maximunValue, string clientSector)
        {
            if (string.IsNullOrEmpty(name))
                throw new InvalidOperationException("Name must be not empty.");

            if (minimumValue < 0 || maximunValue < 0)
                throw new InvalidOperationException("The minimum and maximum values cannot be less than zero.");

            if (minimumValue > maximunValue)
                throw new InvalidOperationException("The minimum value must be less than or equal to the maximum value.");

            Validate.ClientSector(clientSector, true);

            Name = name;
            MinimumValue = minimumValue;
            MaximumValue = maximunValue;
            ClientSector = clientSector;
        }

        public static Category CreateCategory(string name, double minimumValue, double maximunValue, string clientSector)
            => new Category(name, minimumValue, maximunValue, clientSector);

        public static Category CreateCategoryGreaterThan(string name, double minimumValue, string clientSector)
            => new Category(name, minimumValue, double.MaxValue, clientSector);

        public static Category CreateCategoryLessThan(string name, double maximunValue, string clientSector)
            => new Category(name, 0, maximunValue, clientSector);

    }
}
