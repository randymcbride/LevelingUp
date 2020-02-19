using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatterns.Facade
{
	[TestClass]
	public class Demonstration
	{

		//This code runs fine but doesn't do anything. It just demonstrates an opportunity for simplification.
		[TestMethod]
		public void TheHardWay()
		{
			string originUserInput = "12058 S. Window Arch Ln Herriman UT";
			string destinationUserInput = "San Diego CA";

			var geoService = new GeoService();
			var addressService = new AddressService();
			var directionService = new DirectionService();

			string origin = addressService.Search(originUserInput) ?? throw new InvalidAddressException(originUserInput);
			string destination = addressService.Search(destinationUserInput) ?? throw new InvalidAddressException(destinationUserInput);

			Tuple<double, double> originLatLong = geoService.LatAndLong.FromAddress(origin) ?? throw new UnmappedAddressException(originUserInput);
			Tuple<double, double> destinationLatAndLong = geoService.LatAndLong.FromAddress(destination) ?? throw new UnmappedAddressException(destination);

			var directions = directionService.Get(originLatLong, destinationLatAndLong);
		}

		//facade pattern to the rescue. Hide all that complexity please.
		[TestMethod]
		public void WithFacade()
		{
			string originUserInput = "12058 S. Window Arch Ln Herriman UT";
			string destinationUserInput = "San Diego CA";

			var navigationService = new NavigationService();

			try //easy error handling? yes please!
			{
				var directions = navigationService.Get(originUserInput, destinationUserInput);
			}
			catch (InvalidAddressException)
			{
			}
			//gotta catch em all
		}
	}
}
