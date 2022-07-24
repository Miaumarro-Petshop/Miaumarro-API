using FluentResults;

namespace MiauAPI.Services.Abstractions;

/// <summary>
/// Represents an object that's able to validate a controller request.
/// </summary>
/// <typeparam name="T">The type of the request.</typeparam>
public interface IRequestValidator<T>
{
    /// <summary>
    /// Checks if the specified request only contains valid data.
    /// </summary>
    /// <param name="request">The request to be verified.</param>
    /// <param name="errorMessages">A collection of errors identified in the request.</param>
    /// <returns><see langword="true"/> if the request is valid, <see langword="false"/> otherwise.</returns>
    bool IsRequestValid(T request, out IEnumerable<IError> errorMessages);
}