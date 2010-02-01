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
namespace Topshelf.Model.ApplicationDomain
{
    using System;

    public class AppDomainBundle
    {
        readonly AppDomain _domain;
        readonly TopshelfAppDomainManager _manager;

        public AppDomainBundle(AppDomain domain, TopshelfAppDomainManager manager)
        {
            _domain = domain;
            _manager = manager;
        }

        public AppDomain Domain
        {
            get { return _domain; }
        }

        public TopshelfAppDomainManager Manager
        {
            get { return _manager; }
        }

        public void Dispose()
        {
            AppDomain.Unload(_domain);
        }
    }
}