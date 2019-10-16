using AutoMapper;
using System;
using System.Linq;
using System.Reflection;

namespace Blog.Core.Sparrow.Mapping
{
    public static class MappingExtensions
    {
        public static void AppliyMapperConfigurations(this IMapperConfigurationExpression cfg, params Assembly[] assemblies)
        {
            foreach (var assembly in assemblies)
            {
                assembly.GetTypes()
                    .Where(s => s.IsSubclassOf(typeof(MapperConfigurationBase<,>)))
                    .ToList()
                    .ForEach(s =>
                    {
                        var target = s.GetConstructor(new Type[] { }).Invoke(new object[] { });
                        var args = new object[] { cfg };

                        s.InvokeMember("Config", BindingFlags.Public, null, target, args);
                    });
            }
        }
    }
}
