﻿using CSM.Extensions;
using CSM.Networking;

namespace CSM.Commands.Handler
{
    public class TaxRateChangeHandler : CommandHandler<TaxRateChangeCommand>
    {
        public override byte ID => 107;

        public override void HandleOnServer(TaxRateChangeCommand command, Player player) => Handle(command);

        public override void HandleOnClient(TaxRateChangeCommand command) => Handle(command);

        private void Handle(TaxRateChangeCommand command)
        {
            command.Taxrate.CopyTo(EconomyExtension._LastTaxrate, 0);
            command.Taxrate.CopyTo(EconomyExtension._Taxrate, 0);
        }
    }
}