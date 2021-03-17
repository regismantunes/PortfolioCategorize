using PortfolioCategorize_WinForm.Control;
using System;

namespace PortfolioCategorize_WinForm.Model
{
    class Trade : ITrade
    {
        public double Value { get; }
        public string ClientSector { get; }

        public Trade(double value, string clientSector)
        {
            if (value < 0)
                throw new InvalidOperationException("Value cannot be less than zero.");

            Validate.ClientSector(clientSector, true);

            Value = value;
            ClientSector = clientSector;
        }
    }
}
