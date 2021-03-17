using System;

namespace PortfolioCategorize_WinForm.Control
{
    static class Validate
    {
        public static bool ClientSector(string clientSector, bool throwErrorIfInvalid = false)
        {
            if (string.IsNullOrEmpty(clientSector))
            {
                if (throwErrorIfInvalid)
                    throw new InvalidOperationException("Client sector must be not empty.");

                return false;
            }

            string lowerClientSector = clientSector.ToLower();
            if (lowerClientSector != "public" && lowerClientSector != "private")
            {
                if (throwErrorIfInvalid)
                    throw new InvalidOperationException("Client sector must be 'Public' or 'Private'.");

                return false;
            }

            return true;
        }
    }
}
