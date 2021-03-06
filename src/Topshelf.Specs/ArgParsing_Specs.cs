// Copyright 2007-2008 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Topshelf.Specs
{
    using NUnit.Framework;
    using Topshelf.Configuration;

    [TestFixture]
    public class ArgParsing_Specs
    {
        string _args;

        [SetUp]
        public void Establish_Context()
        {
            _args = "install /instance:bob";
        }

        [Test]
        public void InstanceName()
        {
            TopshelfArguments a = TopshelfArgumentParser.Parse(_args);
            a.Instance.ShouldEqual("bob");
            a.ActionName.ShouldEqual(ServiceActionNames.Install);
        }
    }
}