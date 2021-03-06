﻿using System;
using System.Collections.Generic;
using Unity.Builder;
using Unity.Injection;
using Unity.Policy;
using Unity.Resolution;

namespace BookCatalog.Initializer
{
    public class ServiceProviderParametrResolver : ResolverOverride
    {
        private readonly Queue<InjectionParameterValue> _parameterValues;

        public ServiceProviderParametrResolver(IEnumerable<object> parameterValues)
        {
            _parameterValues = new Queue<InjectionParameterValue>();
            foreach (var parameterValue in parameterValues)
            {
                _parameterValues.Enqueue(InjectionParameterValue.ToParameter(parameterValue));
            }
        }

        public override IResolverPolicy GetResolver(IBuilderContext context, Type dependencyType)
        {
            if (_parameterValues.Count < 1)
                return null;

            var value = _parameterValues.Dequeue();
            return value.GetResolverPolicy(dependencyType);
        }
    }
}
