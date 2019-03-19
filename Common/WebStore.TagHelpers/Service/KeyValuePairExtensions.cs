namespace System.Collections.Generic
{
	internal static class KeyValuePairExtensions
	{
		public static void Deconstruct<IKey, IValue>(this KeyValuePair<IKey, IValue> item, out IKey Key, out IValue Value) 
		{
			Key = item.Key;
			Value = item.Value;
		}
	} 
}