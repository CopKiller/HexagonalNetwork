using System;

namespace NetworkHexagonal.Core.Domain.Exceptions;

/// <summary>
/// Exceção base para erros de rede
/// </summary>
public class NetworkException : Exception
{
    public NetworkException(string message) : base(message) { }
    public NetworkException(string message, Exception innerException) : base(message, innerException) { }
}