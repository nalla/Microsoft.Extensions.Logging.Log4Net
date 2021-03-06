using System;
using Extensions.Logging.Log4Net;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.Logging
{
	/// <summary>
	///     Extensions to the <see cref="ILoggerFactory" />
	/// </summary>
	public static class LoggerFactoryExtensions
	{
		/// <summary>
		///      Adds the log4net logging provider.
		/// </summary>
		/// <param name="factory">The logging factory instance.</param>
		/// <param name="repositoryName">The name to be used when creating the log4Net repository.</param>
		/// <param name="configure">
		///     An optional log4net configuration action invoked before the provider is added to the
		///     <see cref="ILoggerFactory" />.
		/// </param>
		/// <returns>The <see ref="ILoggerFactory" /> passed as parameter with the new provider registered.</returns>
		public static ILoggerFactory AddLog4Net(this ILoggerFactory factory, string repositoryName, Action configure = null)
		{
			configure?.Invoke();
			factory?.AddProvider(new Log4NetProvider(repositoryName));

			return factory;
		}
	}
}
