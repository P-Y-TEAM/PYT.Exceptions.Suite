using System;

namespace PYT.Exceptions.Suite
{
	public class EntityDuplicateException : Exception
	{
		public Type? EntityType { get; private set; }
		public string? ParamName { get; private set; }
		public object? ParamValue { get; private set; }
		
		public EntityDuplicateException() : base("Duplicate entity detected.")
		{		
		}

		public EntityDuplicateException(string message) : base(message)
		{
		}

		public EntityDuplicateException(string message, Exception innerException) : base(message, innerException)
		{
		}

		public EntityDuplicateException(Type entityType) : base($"Duplicate {entityType} detected.")
		{
			EntityType = entityType;
		}

		public EntityDuplicateException(Type entityType, string paramName) 
			: base($"Duplicate {entityType} with {paramName}.")
		{
			EntityType = entityType;
			ParamName = paramName;
		}

		public EntityDuplicateException(Type entityType, string paramName, object paramValue)
			: base($"Duplicate {entityType} with {paramName} = {paramValue}.")
		{
			EntityType = entityType;
			ParamName = paramName;
			ParamValue = paramValue;
		}
	}
}