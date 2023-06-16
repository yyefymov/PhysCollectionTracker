using CollectibleAdderLibrary.Interfaces;
using DataModelLibrary.Interfaces;
using DataModelLibrary.Models;
using EFDataHandlerLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectibleAdderLibrary.Impl
{
    public class CollectibleAdder : ICollectibleAdder
    {
        private readonly ICollectionRepository<SwitchGame> _switchGameRepository;
        private readonly ICollectionRepository<CD> _CDRepository;
        private readonly ICollectionRepository<Vinyl> _VinylRepository;

        public CollectibleAdder(ICollectionRepository<SwitchGame> sgr, ICollectionRepository<CD> cr, ICollectionRepository<Vinyl> vr)
        {
            // need to turn this into factory somehow - as theoretically there could be a lot more collectible types

            _switchGameRepository = sgr;
            _CDRepository = cr;
            _VinylRepository = vr;
        }

        public void AddCollectible(string barcode)
        {
            // Barcode Scanner reads the barcode and returns a collectible item object
            // based on the type of the collectible the correct repository type is assigned

            // again, what I want to do here:
            // scan a barcode
            // determine the type of the scanned collectible
            // if it is a Switch Game - use a Switch Game repository to write data, etc

            // how the fuck do I do this though?!

            // the AddCollectible interface should NOT be type-dependent, because the whole point is that
            // the user doesn't know what the barcode means until it is scanned

            // (obviously the user is not a fucking idiot (especially since the user is exclusively me) and can see where he
            // got the barcode from. the point is that the user shouldn't care about the type of the collectible
            // and let the system figure it out for him)

            _switchGameRepository.Add(new SwitchGame());

            throw new NotImplementedException();
        }
    }
}
