using System;

namespace TypeWrapper
{
	#region Interface

	public interface IObject
	{

	}

	#endregion

	#region Wrapper

	public class ObjectWrapper : IObject
	{
		private readonly Object _innerType;

		public ObjectWrapper(Object innerType)
		{
			_innerType = innerType;
		}

	}

	#endregion
}