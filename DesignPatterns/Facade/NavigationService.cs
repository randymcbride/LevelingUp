using System;
using System.Collections.Generic;

namespace DesignPatterns.Facade
{
	internal class NavigationService
	{
		private GeoService geoService;
		private AddressService addressService;
		private DirectionService directionService;

		public NavigationService()
		{
			geoService = new GeoService();
			addressService = new AddressService();
			directionService = new DirectionService();
		}

		internal List<string> Get(string originUserInput, string destinationUserInput)
		{
			string origin = addressService.Search(originUserInput) ?? throw new InvalidAddressException(originUserInput);
			string destination = addressService.Search(destinationUserInput) ?? throw new InvalidAddressException(destinationUserInput);

			Tuple<double, double> originLatLong = geoService.LatAndLong.FromAddress(origin) ?? throw new UnmappedAddressException(originUserInput);
			Tuple<double, double> destinationLatAndLong = geoService.LatAndLong.FromAddress(destination) ?? throw new UnmappedAddressException(destination);

			return directionService.Get(originLatLong, destinationLatAndLong);
		}
	}
}