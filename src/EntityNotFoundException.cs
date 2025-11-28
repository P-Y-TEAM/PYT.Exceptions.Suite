using System;

namespace PYT.Exceptions.Suite
{
    public class EntityNotFoundException : Exception
    {
        public Type? EntityType { get; private set; }
        public string? ParamName { get; private set; }
        public object? ParamValue { get; private set; }

        public EntityNotFoundException() : base("Entity not found.")
        {
        }

        public EntityNotFoundException(string message) : base(message)
        {
        }

        public EntityNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public EntityNotFoundException(Type entityType) : base($"{entityType} not found.")
        {
            EntityType = entityType;
        }

        public EntityNotFoundException(Type entityType, string paramName)
            : base($"{entityType} not found with {paramName}.")
        {
            EntityType = entityType;
            ParamName = paramName;
        }

        public EntityNotFoundException(Type entityType, string paramName, object paramValue)
            : base($"{entityType} not found with {paramName} = {paramValue}.")
        {
            EntityType = entityType;
            ParamName = paramName;
            ParamValue = paramValue;
        }
    }
}

