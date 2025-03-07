// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.TestUtilities;
using Xunit;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class RelationalShapedQueryOptimizerDependenciesTest
    {
        [ConditionalFact]
        public void Can_use_With_methods_to_clone_and_replace_service()
        {
            RelationalTestHelpers.Instance.TestDependenciesClone<RelationalShapedQueryOptimizerDependencies>();
        }
    }
}
