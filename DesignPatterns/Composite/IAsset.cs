using System;

namespace DesignPatterns.Composite
{
	public interface IAsset
	{
		decimal Return(DateTime? begin = null, DateTime? end = null);
		decimal Value { get; }
	}
}
