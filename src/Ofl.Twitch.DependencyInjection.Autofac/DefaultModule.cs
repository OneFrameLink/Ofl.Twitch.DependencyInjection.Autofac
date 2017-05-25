using System;
using Autofac;
using Ofl.Twitch.V5;

namespace Ofl.Twitch.DependencyInjection.Autofac
{
    public class DefaultModule : Module
    {
        #region Overrides of Module

        protected override void Load(ContainerBuilder builder)
        {
            // Validate parameters.
            if (builder == null) throw new ArgumentNullException(nameof(builder));

            // Bind.
            builder.RegisterType<TwitchUtilities>().As<ITwitchUtilities>();
            builder.RegisterType<TwitchClient>().As<ITwitchClient>();
            builder.RegisterType<ConfigurationClientIdProvider>().As<IClientIdProvider>();
        }

        #endregion
    }
}
